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
            Output = 2
        }

        public int inputNeuronsCount { get; }
        public int outputNeuronsCount { get; }
        public List<int> middleLayers { get; }

        public Structure(int temp_inputCount, int temp_outputCount, params int[] temp_middleLayers)
        {
            inputNeuronsCount = temp_inputCount;
            outputNeuronsCount = temp_outputCount;
            middleLayers = new List<int>();
            middleLayers.AddRange(temp_middleLayers);
        }
    }
}
