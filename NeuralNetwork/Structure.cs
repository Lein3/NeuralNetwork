using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLibrary
{
    public class Structure
    {
        public enum NeuronType
        {
            Input = 0,
            Normal = 1,
            Output = 2
        }

        public int inputNeuronsCount { get; }
        public int outputNeuronsCount { get; }
        public List<int> middleLayers { get; }
        public double learningRate { get; }

        public Structure(int temp_inputCount, int temp_outputCount, double temp_learningRate, params int[] temp_middleLayers)
        {
            inputNeuronsCount = temp_inputCount;
            outputNeuronsCount = temp_outputCount;
            middleLayers = new List<int>();
            middleLayers.AddRange(temp_middleLayers);
            learningRate = temp_learningRate;
        }
    }
}
