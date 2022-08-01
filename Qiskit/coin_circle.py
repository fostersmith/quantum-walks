import sys
from time import perf_counter
import matplotlib.pyplot as plt
import numpy as np

# importing QISKit
from qiskit import QuantumCircuit, ClassicalRegister, QuantumRegister, transpile
from qiskit import Aer, IBMQ, execute

from qiskit.tools.monitor import job_monitor
from qiskit.providers.ibmq import least_busy
from qiskit.tools.visualization import plot_histogram

my_provider = IBMQ.load_account()
#sim_backend = Aer.get_backend('qasm_simulator')
device_backend = my_provider.get_backend('ibm_oslo')

t=8 #time

q1 = QuantumRegister(4)
c1 = ClassicalRegister(4)
qw1 = QuantumCircuit(q1, c1)

start = perf_counter()
qw1.x(q1[1])
qw1.cx(q1[2], q1[1])
qw1.u(t, 0, 0, q1[2])
qw1.cx(q1[2], q1[0])
qw1.u(t, 0, 0, q1[2])
qw1.cx(q1[2], q1[0])
qw1.cx(q1[2], q1[1])
qw1.u(2*t, 0, 0, q1[2])

qw1.measure(q1[0], c1[0])
qw1.measure(q1[1], c1[1])
qw1.measure(q1[2], c1[2])
end = perf_counter()

qw1 = transpile(qw1, backend=device_backend, optimization_level=3)


print(f"Circuit construction took {(end - start)} sec.")

active_qubits = {}
for op in qw1.data: 
    if op[0].name != "barrier" and op[0].name != "snapshot": 
        for qubit in op[1]: 
            active_qubits[qubit.index] = True
print(f"Width: {len(active_qubits)} qubits")

print(f"Depth: {qw1.depth()}")

print(f"Gate counts: {qw1.count_ops()}")

job = execute(qw1, device_backend, shots=1024)
qw1.draw(output='mpl')
job_monitor(job)

result = job.result()

histogram = {}

for(measured_state, count) in result.get_counts().items():

        big_endian_state = measured_state[::-1]
        measured_state = big_endian_state

        histogram.update({big_endian_state:count})

plot_histogram(histogram)