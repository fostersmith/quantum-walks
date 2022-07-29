using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Threading.Tasks;

namespace DummyQS{
    class Driver{
        static void Main(string[] args){
            //Console.WriteLine("hello");
            int bits = 4;
            int steps = 3;
            int iterations = 1000;
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