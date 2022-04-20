using System;
using System.Collections.Generic;

namespace NeuralNetwork
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

        public bool Bias { get; private set; }
        public int InputNeuronsCount { get; private set; }
        public int OutputNeuronsCount { get; private set; }
        public List<int> MiddleLayers { get; private set; }

        public Structure(int temp_inputCount, int temp_outputCount, params int[] temp_middleLayers)
        {
            Bias = false;
            InputNeuronsCount = temp_inputCount;
            OutputNeuronsCount = temp_outputCount;
            MiddleLayers = new List<int>(temp_middleLayers);
        }

        public Structure(bool temp_bias, int temp_inputCount, int temp_outputCount, params int[] temp_middleLayers)
        {
            Bias = temp_bias;
            InputNeuronsCount = temp_inputCount;
            OutputNeuronsCount = temp_outputCount;
            MiddleLayers = new List<int>(temp_middleLayers);
        }
    }
}
