import qiskit
import numpy as np
import matplotlib as mpl
from qiskit import Aer, QuantumCircuit, ClassicalRegister, QuantumRegister, execute
from qiskit.tools.visualization import plot_histogram, plot_state_city

# Changeable constants
n = 3
step = 3

# Declaring registers
qnodes = QuantumRegister(n,'quantum_walker')
qsubnodes = QuantumRegister(1,'quantum_coin')
csubnodes = ClassicalRegister(1,'classical_coin_register')
cnodes = ClassicalRegister(n,'classical_walker_register')

circuit = QuantumCircuit(qnodes, qsubnodes, cnodes, csubnodes)

# Applies a clockwise rotation around the graph
def increment_gate(circuit, register, subnode):
  
  circuit.mct([subnode, register[2], register[1]], register[0])
  circuit.mct([subnode, register[2]], register[1])
  circuit.cx(subnode, register[2])
  circuit.barrier()
  return circuit

# Applies a counterclockwise rotation around the graph
def decrement_gate(circuit, register, subnode):

  circuit.x(subnode)
  circuit.x(register[2])
  circuit.x(register[1])
  circuit.mct([subnode, register[2], register[1]], register[0])
  circuit.x(register[1])
  circuit.mct([subnode, register[2]], register[1])
  circuit.x(register[2])
  circuit.cx(subnode, register[2])
  circuit.x(subnode)
  return circuit

# Runs circuit
def ibmsim(circuit):
  simulator = Aer.get_backend('aer_simulator')
  return execute(circuit, simulator, shots=1000).result().get_counts(circuit)  

# Rerun the coin and shift operations for a number of steps
def runQWC(circuit, times):
    for i in range(times):
        # Coin operation
        circuit.h(qsubnodes[0])
        # Shift operations
        increment_gate(circuit, qnodes, qsubnodes[0])
        decrement_gate(circuit,qnodes,qsubnodes[0])
        circuit.measure(qnodes, cnodes)

    return circuit

circuit = runQWC(circuit, step)
circuit.draw(output="mpl")
result = ibmsim(circuit)

print(result)

plot_histogram(result)