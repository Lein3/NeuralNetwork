using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class LearningExample
    {
        public List<double> InputSignals { get; set; }
        public List<double> ExpectedOutputs { get; set; }

        public LearningExample(List<double> tempInputSignals, List<double> tempExpectedOutputs)
        {
            InputSignals = tempInputSignals;
            ExpectedOutputs = tempExpectedOutputs;
        }
    }
}
