using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Threading.Tasks;

namespace AnotherExample{
    class Driver{
        static void Main(string[] args){
            int maxsteps = 10;
            for(int steps = 1; steps <= maxsteps; ++steps){
                int iterations = 1000;  // # of times to test
                int[] results = new int[2];
                using (QuantumSimulator simulator = new QuantumSimulator()){
                    for(int i = 0; i < iterations; ++i){
                        var quantumTask = LoopedWalk.Run(simulator, steps);
                        if(quantumTask.Result){
                            ++results[0];
                        } else{
                            ++results[1];
                        }
                    }
                }
                Console.Write(steps+"\t");
                for(int i = 0; i < results.Length; ++i){
                    Console.Write(results[i]);
                    Console.Write(",");
                }
                Console.WriteLine();
            }
        }
    }
}