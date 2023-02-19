using System.Collections.Generic;
using NeuralNetworkNamespace;

namespace Constructor
{
    internal static class NetworkTemplate
    {
        public static LearningData LearningData { get; set; }
        public static string Path { get; set; }
        public static Structure Structure { get; set; }
        public static NeuralNetwork NeuralNetwork { get; set; }
        public static List<Layer> Layers { get; set; }
        static NetworkTemplate()
        {
            LearningData = new LearningData();
            Structure = new Structure();
            Layers = new List<Layer>();
        }
    }
}
