using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            expectedOutputs.Add(new double[] { 255, 0 });
            expectedOutputs.Add(new double[] { 255, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 255, 0 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 0, 1 });
            expectedOutputs.Add(new double[] { 255, 1 });

            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            Structure structure = new Structure(3, 2, 6, 6);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 5000);

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
            Structure structure = new Structure(13, 1, 6, 3);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 10000);
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
            neuralNetwork.Learn_Backpropogation(learningData, 100000, 0.01);

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
            neuralNetwork.Learn_Backpropogation(learningData, 5000);
            foreach (var example in learningData.LearningExamples)
            {
                var inputSignals = example.InputSignals;
                var expectedOutputs = example.ExpectedOutputs;
                var answer = neuralNetwork.Predict(inputSignals);
            }
        }

        [TestMethod]
        public void Statistics_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv");
            Structure structure = new Structure(false, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 5000, 0.1);
            var kek = neuralNetwork.LearningStatistics.MAE;
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
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv", 2);
            Structure structure = new Structure(13, 1, 10, 5); // 13 10 1
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 20000, 0.1);

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
    }
}
