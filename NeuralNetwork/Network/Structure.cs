using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    [Serializable]
    public class Structure
    {
        public enum NeuronType { Input = 0, Normal = 1, Output = 2, Bias = 3 }
        public bool Bias { get; set; }
        public int InputNeuronsCount { get;  set; }
        public int OutputNeuronsCount { get;  set; }
        public List<int> MiddleLayers { get;  set; }

        public Structure()
        {
            Bias = false;
        }

        public Structure(int tempInputCount, int tempOutputCount, params int[] tempMiddleLayers)
        {
            Bias = false;
            InputNeuronsCount = tempInputCount;
            OutputNeuronsCount = tempOutputCount;
            MiddleLayers = new List<int>(tempMiddleLayers);
        }

        public Structure(bool tempBias, int tempInputCount, int tempOutputCount, params int[] tempMiddleLayers) //два конструктора потому что будет не красиво с порядком
        {
            Bias = tempBias;
            InputNeuronsCount = tempInputCount;
            OutputNeuronsCount = tempOutputCount;
            MiddleLayers = new List<int>(tempMiddleLayers);
        }
    }
}
