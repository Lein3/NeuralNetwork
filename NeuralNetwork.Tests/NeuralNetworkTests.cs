using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkNamespace.Tests
{
    [TestClass]
    public class NeuralNetworkTests
    {
        #region общее

        [TestMethod]
        public void NormalizationComlete_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv");
            Structure structure = new Structure(13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            Assert.AreEqual(learningData.ParamNamesInput.First(), neuralNetwork.Layers.First().Neurons.First().Name);
            Assert.AreEqual(learningData.ParamNamesInput.Last(), neuralNetwork.Layers.First().Neurons.Last().Name);
        }

        [TestMethod]
        public void StatisticsNotNull_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv");
            Structure structure = new Structure(13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 50);
            Assert.IsNotNull(neuralNetwork.LearningStatistics.MSE);
            Assert.IsNotNull(neuralNetwork.LearningStatistics.MAE);
        }

        #endregion

        #region регрессия

        [TestMethod]
        public void Regression_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\дома.csv");
            Structure structure = new Structure(7, 1, 5);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 100);
            var real2 = neuralNetwork.Predict_ReturnOnlyValues(learningData.LearningExamples[0].InputSignals);

            for (int i = 0; i < learningData.LearningExamples.Count; i++)
            {
                var example = learningData.LearningExamples[i].InputSignals;
                var answer = learningData.LearningExamples[i].ExpectedOutputs;
                var real = neuralNetwork.Predict_ReturnOnlyValues(example);
                //Assert.AreEqual(answer[0], real[0], 0.20);
            }

            for (int i = 0; i < learningData.TestExamples.Count; i++)
            {
                var example = learningData.TestExamples[i].InputSignals;
                var answer = learningData.TestExamples[i].ExpectedOutputs;
                var real = neuralNetwork.Predict_ReturnOnlyValues(example);
                //Assert.AreEqual(answer[0], real[0], 0.20);
            }
        }

        [TestMethod]
        public void RegressionProblem_Test()
        {
            var inputSignals = new List<double[]>();
            var expectedOutputs = new List<double[]>();

            inputSignals.Add(new double[] { 1 });
            inputSignals.Add(new double[] { 2 });
            inputSignals.Add(new double[] { 3 });
            inputSignals.Add(new double[] { 4 });
            inputSignals.Add(new double[] { 5 });
            inputSignals.Add(new double[] { 6 });
            inputSignals.Add(new double[] { 7 });

            expectedOutputs.Add(new double[] { 1 });
            expectedOutputs.Add(new double[] { 2 });
            expectedOutputs.Add(new double[] { 3 });
            expectedOutputs.Add(new double[] { 4 });
            expectedOutputs.Add(new double[] { 5 });
            expectedOutputs.Add(new double[] { 6 });
            expectedOutputs.Add(new double[] { 7 });

            var ForAnswer = new List<double>() { 8 };

            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            Structure structure = new Structure(false, 1, 1);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);

            foreach (var neuron in neuralNetwork.Layers.First().Neurons)
            {
                neuron.Max = 7;
            }
            foreach (var neuron in neuralNetwork.Layers.Last().Neurons)
            {
                neuron.Max = 7;
            }
            neuralNetwork.Learn_Backpropogation(learningData, 100);
            var kek = neuralNetwork.Predict_ReturnOnlyValues(ForAnswer);

            //throw new NotImplementedException();
        }

        #endregion

        #region бинарная

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

            expectedOutputs.Add(new double[] { 0 });
            expectedOutputs.Add(new double[] { 1 });
            expectedOutputs.Add(new double[] { 1 });
            expectedOutputs.Add(new double[] { 0 });
            expectedOutputs.Add(new double[] { 1 });
            expectedOutputs.Add(new double[] { 0 });
            expectedOutputs.Add(new double[] { 0 });
            expectedOutputs.Add(new double[] { 1 });

            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            Structure structure = new Structure(3, 1, 6);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 1000);

            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.05);
            }
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
            neuralNetwork.Learn_Backpropogation(learningData, 100000, 0.01);

            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.09);
            }
        }

        [TestMethod]
        public void RandomPatient_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
            Structure structure = new Structure(false, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 5000);

            Random rnd = new Random(new Guid().GetHashCode());
            var answers = new List<double>();
            for (int i = 0; i < 1000; i++)
            {
                var person = new List<double>();
                for (int j = 0; j < neuralNetwork.Layers.First().Neurons.Count; j++)
                {
                    var neuron = neuralNetwork.Layers.First().Neurons[j];
                    int min = Convert.ToInt32(Math.Round(neuron.Min * 0.95));
                    int max = Convert.ToInt32(Math.Round(neuron.Max * 1.05));
                    var data = rnd.Next(min, max);
                    person.Add(data);
                }
                var currentAnswer = neuralNetwork.Predict_ReturnOnlyValues(person)[0];
                currentAnswer = Math.Round(currentAnswer, 3);
                answers.Add(currentAnswer);
            }
            answers.Sort();
        }

        [TestMethod]
        public void CreateLearningDataWithPercents_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv", 10);
            Structure structure = new Structure(true, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            Assert.AreEqual(273, learningData.LearningExamples.Count);
            Assert.AreEqual(30, learningData.TestExamples.Count);
        }

        [TestMethod]
        public void TestExapmles_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv");
            Structure structure = new Structure(13, 1, 10); // 13 10 1 // 13 10 5 1
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 10000, 0.1);

            for (int i = 0; i < learningData.LearningExamples.Count; i++)
            {
                var example = learningData.LearningExamples[i].InputSignals;
                var answer = learningData.LearningExamples[i].ExpectedOutputs;
                var real = neuralNetwork.Predict_ReturnOnlyValues(example);
                Assert.AreEqual(answer[0], real[0], 0.20);
            }

            //for (int i = 0; i < learningData.TestExamples.Count; i++)
            //{
            //    var example = learningData.TestExamples[i].InputSignals;
            //    var answer = learningData.TestExamples[i].ExpectedOutputs;
            //    var real = neuralNetwork.Predict_ReturnOnlyValues(example);
            //    Assert.AreEqual(answer[0], real[0], 0.20);
            //}
        }

        #endregion
    }
}
