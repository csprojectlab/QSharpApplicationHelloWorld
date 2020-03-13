using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication1
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                //var bitString = "0";    // To save bits
                //int max = 50;  // Maximum range
                //int size = Convert.ToInt32(Math.Floor(Math.Log(max, 2.0) + 1));

                //int output = max + 1;    // Int to store the output
                //while (output > max)
                //{
                //    bitString = "0";   // Restart the bit if it fails

                //}
                SampleQuantumRandomNumberGenerator.Run(qsim).Wait();    
            }
        }
    }
}