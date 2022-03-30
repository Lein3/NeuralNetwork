using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLibrary
{
    public class LearningExample
    {
        public List<double> inputSignals { get; set; }
        public List<double> expectedOutputs { get; set; }

        public LearningExample(List<double> temp_inputSignals, List<double> temp_expectedOutputs)
        {
            inputSignals = temp_inputSignals;
            expectedOutputs = temp_expectedOutputs;
        }
    }
}
