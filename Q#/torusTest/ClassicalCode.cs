using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Core;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DummyQS{
    class Driver{
        static void Main(string[] args){
            //Console.WriteLine("hello");
            int xBits = 4;
            int yBits = 4;
            int steps = 1;
            int iterations = 1000;
            int[,] results = new int[(int)Math.Pow(2,yBits), (int)Math.Pow(2,xBits)];
            using (QuantumSimulator simulator = new QuantumSimulator()){
                for(int i = 0; i < iterations; ++i){
                    var quantumTask = LoopedWalk.Run(simulator, xBits, yBits, steps);
                    var resultX = quantumTask.Result[0];
                    var resultY = quantumTask.Result[1];
                    results[resultY, resultX]++;
                }
            }

            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write(results[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}