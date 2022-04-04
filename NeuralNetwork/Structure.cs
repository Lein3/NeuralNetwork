using System;
using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class Structure
    {
        public enum NeuronType
        {
            Input = 0,
            Normal = 1,
            Output = 2,
            Bias = 3
        }

        public bool bias { get; }
        public int inputNeuronsCount { get; }
        public int outputNeuronsCount { get; }
        public List<int> middleLayers { get; }

        public Structure(bool temp_bias, int temp_inputCount, int temp_outputCount, params int[] temp_middleLayers)
        {
            bias = temp_bias;
            inputNeuronsCount = temp_inputCount;
            outputNeuronsCount = temp_outputCount;
            middleLayers = new List<int>(temp_middleLayers);
        }
    }
}
