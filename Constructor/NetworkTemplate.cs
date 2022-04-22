using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworkNamespace;

namespace Constructor
{
    internal static class NetworkTemplate
    {
        public static LearningData LearningData { get; set; }
        public static Structure Structure { get; set; }
        public static NeuralNetwork NeuralNetwork { get; set; }

        static NetworkTemplate()
        {
            LearningData = new LearningData();
            Structure = new Structure();
        }
    }
}
