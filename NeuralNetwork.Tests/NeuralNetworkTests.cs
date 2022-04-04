using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkLibrary.Tests
{
    [TestClass]
    public class NeuralNetworkTests
    {
        [TestMethod]
        public void Normalization_Success_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
            Structure structure = new Structure(true, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
        }

        [TestMethod]
        public void Normalization_Names_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
        }

        [TestMethod]
        public void XOR3function_Test()
        {
            var inputSignals = new List<double[]>();
            var expectedOutputs = new List<double[]>();

            inputSignals.Add(new double[] { 0, 0, 0 });
            inputSignals.Add(new double[] { 0, 0, 1 });
            inputSignals.Add(new double[] { 0, 1, 0 });
            inputSignals.Add(new double[] { 0, 1, 1 });
            inputSignals.Add(new double[] { 1, 0, 0 });
            inputSignals.Add(new double[] { 1, 0, 1 });
            inputSignals.Add(new double[] { 1, 1, 0 });
            inputSignals.Add(new double[] { 1, 1, 1 });

            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 1, 0 });
            expectedOutputs.Add(new double[] { 1, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 1, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });

            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            Structure structure = new Structure(true, 3, 2, 6, 6);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Learn(learningData, 5000);

            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.05);
            }           
        }

        [TestMethod]
        public void Normalization_Learn_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
            Structure structure = new Structure(true, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn(learningData, 5000);
            var templist = new List<double> { 64, 1, 3, 145, 233, 1, 0, 150, 0, 2.3, 0, 0, 1 };
            var result = neuralNetwork.Predict_ReturnOnlyValues(templist);
            Assert.AreEqual(result[0], 1, 0.05);
        }

        [TestMethod]
        public void Image_Lines_Test()
        {
            var inputSignals = new List<double[]>();
            var expectedOutputs = new List<double[]>();

            inputSignals.Add(new double[] { 1, 1, 1, 0, 0, 0, 0, 0, 0 }); 
            expectedOutputs.Add(new double[] { 1, 0 });

            inputSignals.Add(new double[] { 0, 0, 0, 1, 1, 1, 0, 0, 0 });
            expectedOutputs.Add(new double[] { 1, 0 });

            inputSignals.Add(new double[] { 0, 0, 0, 0, 0, 0, 1, 1, 1 });
            expectedOutputs.Add(new double[] { 1, 0 });
            //
            inputSignals.Add(new double[] { 1, 0, 0, 1, 0, 0, 1, 0, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });

            inputSignals.Add(new double[] { 0, 1, 0, 0, 1, 0, 0, 1, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });

            inputSignals.Add(new double[] { 0, 0, 1, 0, 0, 1, 0, 0, 1 });
            expectedOutputs.Add(new double[] { 0, 1 });
            //
            inputSignals.Add(new double[] { 1, 1, 1, 1, 0, 0, 1, 0, 0 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 1, 1, 1, 0, 1, 0, 0, 1, 0 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 1, 1, 1, 0, 0, 1, 0, 0, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });
            //
            inputSignals.Add(new double[] { 1, 0, 0, 1, 1, 1, 1, 0, 0 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 0, 1, 0, 1, 1, 1, 0, 1, 0 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 0, 0, 1, 1, 1, 1, 0, 0, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });
            //
            inputSignals.Add(new double[] { 1, 0, 0, 1, 0, 0, 1, 1, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 0, 1, 0, 0, 1, 0, 1, 1, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });

            inputSignals.Add(new double[] { 0, 0, 1, 0, 0, 1, 1, 1, 1 });
            expectedOutputs.Add(new double[] { 1, 1 });
            //
            inputSignals.Add(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            expectedOutputs.Add(new double[] { 0, 0 });

            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            Structure structure = new Structure(false, 9, 2, 5, 4);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Learn(learningData, 100000, 0.01);

            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.09);
            }
        }

        [TestMethod]
        public void Tuple_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
            Structure structure = new Structure(true, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn(learningData, 5000);
            foreach (var example in learningData.examples)
            {
                var inputSignals = example.inputSignals;
                var expectedOutputs = example.expectedOutputs;
                var answer = neuralNetwork.Predict(inputSignals);
            }
        }
    }
}
