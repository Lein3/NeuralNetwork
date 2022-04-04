using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    public class LearningExample
    {
        public List<double> InputSignals { get; set; }
        public List<double> ExpectedOutputs { get; set; }

        public LearningExample(List<double> temp_inputSignals, List<double> temp_expectedOutputs)
        {
            InputSignals = temp_inputSignals;
            ExpectedOutputs = temp_expectedOutputs;
        }
    }
}
