using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Threading.Tasks;

namespace CircleTest{
    class Driver{
        static void Main(string[] args){
            int bits = 4;   // # of bits used to represent index of walker
            int steps = 3;  // # of steps taked by the walker
            int iterations = 1000;  // # of times to test
            int[] results = new int[(int)Math.Pow(2,bits)];
            using (QuantumSimulator simulator = new QuantumSimulator()){
                for(int i = 0; i < iterations; ++i){
                    Task<long> quantumTask = LoopedWalk.Run(simulator, bits, steps);
                    long result = quantumTask.Result;
                    results[result]++;
                }
            }
            for(int i = 0; i < results.Length; ++i){
                Console.Write(results[i]);
                Console.Write(",");
            }
        }
    }
}