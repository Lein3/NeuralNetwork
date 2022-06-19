using NeuralNetworkNamespace;

namespace Constructor
{
    public static class GlobalTemplate
    {
        public static Users CurrentUser { get; set; }

        public enum WorkMode { autoMode, professionalMode, freeMode };

        public static WorkMode CurrentWorkMode { get; set; }

        public enum Scenario { binaryClassification, multiclassClassification, multimarkClassification };

        public static Scenario CurrentScenario { get; set; }

        public static LearningData LearningData { get; set; }

        public static bool Loaded { get; set; }

        public static NeuralNetwork NeuralNetwork { get; set; }

        public static NeuralNetworks DatabaseNeuralNetwork { get; set; }

        public static string ModelName { get; set; }

    }
}
