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
        public void NeuronConstructor_Test()
        {
            Neuron neuron = new Neuron_Normal(10);
            Assert.IsNotNull(neuron);
            Assert.IsNotNull(neuron.Weights);
        }

        [TestMethod]
        public void NeuronProccessInformation_Test()
        {
            Neuron neuron = new Neuron_Normal(3);
            neuron.Weights = new List<double>() { -1, 0, 1 };
            neuron.ActivationFunction = new Sigmoid();
            neuron.ProcessInformation(new List<double>() { 3, 2, 1 });
            Assert.AreEqual(neuron.Sum, -2);
            Assert.AreEqual(neuron.Output, 0.119, 0.01);
        }

        [TestMethod]
        public void NeuronChangeWeightsErrorNotEqualsZero_Test()
        {
            Neuron neuron = new Neuron_Normal(3);
            neuron.Weights = new List<double>() { -1, 0, 1 };
            neuron.Inputs = new List<double>() { 1, 1, 1 };
            neuron.Error = 5;
           
            neuron.Learn_ChangeWeights(1);
            var oldWeights = new List<double>(neuron.Weights);
            var newWeights = new List<double>() { -6, -5, -4};

            for (int i = 0; i < oldWeights.Count; i++)
                Assert.AreEqual(oldWeights[i], newWeights[i]);
        }

        [TestMethod]
        public void NeuronChangeWeightsErrorEqualsZero_Test()
        {
            Neuron neuron = new Neuron_Normal(3);
            neuron.Weights = new List<double>() { -1, 0, 1 };
            neuron.Inputs = new List<double>() { 1, 1, 1 };
            neuron.Error = 0;

            var oldWeights = new List<double>(neuron.Weights);
            neuron.Learn_ChangeWeights(1);
            var newWeights = new List<double>(neuron.Weights);

            for (int i = 0; i < oldWeights.Count; i++)
                Assert.AreEqual(oldWeights[i], newWeights[i]);
        }

        [TestMethod]
        public void LayerConstrucor_Test()
        {
            List<Neuron> neurons = new List<Neuron>();
            for (int i = 0; i < 9; i++)
                neurons.Add(new Neuron_Normal(3) { Name = "нейрон " + i.ToString()});

            Layer layer = new Layer(neurons);
            Assert.IsNotNull(layer);
            for (int i = 0; i < layer.Neurons.Count; i++)
                Assert.AreEqual(layer.Neurons[i].Name, "нейрон " + i.ToString());
        }

        [TestMethod]
        public void LayerGetSignals_Test()
        {
            List<Neuron> neurons = new List<Neuron>();
            for (int i = 0; i < 5; i++)
                neurons.Add(new Neuron_Normal(3) { Output = 1 });

            Layer layer = new Layer(neurons);
            var signals = layer.GetSignals();
            var expected = new List<double>() { 1, 1, 1, 1, 1 };
            for (int i = 0; i < signals.Count; i++)
                Assert.AreEqual(signals[i], expected[i]);
        }

        [TestMethod]
        public void NeuralNetworkGetAnserNotNull_Test()
        {
            Structure structure = new Structure(5, 1, 5);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            var input = new List<double>() { 1, 1, 1, 1, 1 };
            var anser = neuralNetwork.Predict(input);
            Assert.IsNotNull(anser);
        }

        [TestMethod]
        public void NormalizationComlete_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv", ',');
            Structure structure = new Structure(13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            Assert.AreEqual(learningData.ParamNamesInput.First(), neuralNetwork.Layers.First().Neurons.First().Name);
            Assert.AreEqual(learningData.ParamNamesInput.Last(), neuralNetwork.Layers.First().Neurons.Last().Name);
        }

        [TestMethod]
        public void StatisticsNotNull_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv", ',');
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
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv", ',');
            Structure structure = new Structure(7, 1, 10);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 1);
            var real2 = neuralNetwork.Predict_ReturnOnlyValues(learningData.LearningExamples[0].InputSignals);

            for (int i = 0; i < learningData.LearningExamples.Count; i++)
            {
                var example = learningData.LearningExamples[i].InputSignals;
                var answer = learningData.LearningExamples[i].ExpectedOutputs;
                var real = neuralNetwork.Predict_ReturnOnlyValues(example);
                //Assert.AreEqual(answer[0], real[0], 0.20);
            }
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
            Structure structure = new Structure(3, 1, 6, 6);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 10000);

            var answers = new List<double>();
            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                answers.Add(neuralNetwork.Predict_ReturnOnlyValues(input.ToList())[0]);
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.1);
            }
            //пиздец столько ебался а в итоге просто мало эпох было указано
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
            neuralNetwork.Learn_Backpropogation(learningData, 10000);

            for (int i = 0; i < 8; i++)
            {
                var input = inputSignals[i];
                var result = neuralNetwork.Predict_ReturnOnlyValues(input.ToList());
                Assert.AreEqual(expectedOutputs[i][0], result[0], 0.09);
                Assert.AreEqual(expectedOutputs[i][1], result[1], 0.09);
            }
        }

        [TestMethod]
        public void RandomPatient_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv", ',');
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
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\болезни.csv", ',');
            Structure structure = new Structure(true, 13, 1, 7);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            Assert.AreEqual(273, learningData.LearningExamples.Count);
            Assert.AreEqual(30, learningData.TestExamples.Count);
        }

        [TestMethod]
        public void TestExapmles_Test()
        {
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\NeuralNetwork\болезни.csv", ',');
            Structure structure = new Structure(30, 1, 15); // 13 10 1 // 13 10 5 1
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn_Backpropogation(learningData, 1, 0.1);

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

        [TestMethod]
        public void Converttttttttt()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string a = "0.5";
            var kek = Convert.ToDouble(a);
            string b = "0,5";
            var kek2 = Convert.ToDouble(b);
        }

        #endregion
    }
}
