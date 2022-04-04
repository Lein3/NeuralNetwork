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

        public bool Bias { get; }
        public int InputNeuronsCount { get; }
        public int OutputNeuronsCount { get; }
        public List<int> MiddleLayers { get; }

        public Structure(bool temp_bias, int temp_inputCount, int temp_outputCount, params int[] temp_middleLayers)
        {
            Bias = temp_bias;
            InputNeuronsCount = temp_inputCount;
            OutputNeuronsCount = temp_outputCount;
            MiddleLayers = new List<int>(temp_middleLayers);
        }
    }
}
