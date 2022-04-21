using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    [Serializable]
    public class NeuralNetwork
    {
        public Structure Structure { get; private set; }
        public List<Layer> Layers { get; private set; }
        public LearningStatistics LearningStatistics { get; private set; }

        public NeuralNetwork(Structure temp_Structure)
        {
            Structure = temp_Structure;
            Layers = new List<Layer>();
            LearningStatistics = new LearningStatistics();
            CreateInputLayer();
            CreateMiddleLayers();
            CreateOutputLayer();
        }

        #region СозданиеСлоев
        private void CreateInputLayer()
        {
            List<Neuron> inputNeurons = new List<Neuron>();
            for (int i = 0; i < Structure.InputNeuronsCount; i++)
            {
                Neuron neuron = new Neuron_Input();
                inputNeurons.Add(neuron);
            }
            if (Structure.Bias)
            {
                Neuron bias = new Neuron_Bias();
                inputNeurons.Add(bias);
            }
            Layer inputLayer = new Layer(inputNeurons);
            Layers.Add(inputLayer);
        }

        private void CreateMiddleLayers()
        {
            for (int i = 0; i < Structure.MiddleLayers.Count; i++)
            {
                List<Neuron> middleNeurons = new List<Neuron>();
                Layer lastLayerNeuronCount = Layers.Last();
                for (int j = 0; j < Structure.MiddleLayers[i]; j++)
                {
                    Neuron neuron = new Neuron_Normal(lastLayerNeuronCount.Neurons.Count);
                    middleNeurons.Add(neuron);
                }
                if (Structure.Bias)
                {
                    Neuron bias = new Neuron_Bias();
                    middleNeurons.Add(bias);
                }
                Layer middleLayer = new Layer(middleNeurons);
                Layers.Add(middleLayer);
            }
        }

        private void CreateOutputLayer()
        {
            List<Neuron> outputNeurons = new List<Neuron>();
            Layer lastLayerNeuronCount = Layers.Last();
            for (int i = 0; i < Structure.OutputNeuronsCount; i++)
            {
                Neuron neuron = new Neuron_Output(lastLayerNeuronCount.Neurons.Count);
                outputNeurons.Add(neuron);
            }
            Layer outputLayer = new Layer(outputNeurons);
            Layers.Add(outputLayer);
        }
        #endregion

        #region РасчетыОтвета
        public List<(string Name, double Output, double NormalizedOutput)> Predict(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return Layers.Last().GetAnswer();
        }

        public List<double> Predict_ReturnOnlyValues(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return Layers.Last().GetSignals();
        }

        private void SendSignalsToInputLayer(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; i++)
            {
                List<double> signal = new List<double> { inputSignals[i] };
                Layers.First().Neurons[i].ProcessInformation(signal);
            }
        }

        private void SendSignalsAfterInputLayer()
        {
            for (int i = 1; i < Layers.Count; i++)
            {
                Layer layer = Layers[i];
                List<double> previousLayerSignals = Layers[i - 1].GetSignals();
                foreach (Neuron neuron in layer.Neurons)
                    neuron.ProcessInformation(previousLayerSignals);
            }
        }
        #endregion

        #region Обучение
        public void Learn_Backpropogation(LearningData learningData, double limit, double learningRate = 0.1)
        {
            do
            {
                var currentEpochErrorsMAE = new List<double>();
                var currentEpochErrorsMSE = new List<double>();
                for (int j = 0; j < learningData.LearningExamples.Count; j++)
                {
                    LearningExample example = learningData.LearningExamples[j];
                    Learn_RecalculateError(example.InputSignals, example.ExpectedOutputs);
                    Learn_ChangeWeights(learningRate);
                    currentEpochErrorsMAE.Add(Math.Abs(Layers.Last().Neurons.Last().Error));
                    currentEpochErrorsMSE.Add(Math.Pow(Layers.Last().Neurons.Last().Error, 2));
                }
                currentEpochErrorsMAE.Sort();
                var temp = currentEpochErrorsMAE.Average();
                LearningStatistics.MAE.Add(currentEpochErrorsMAE.Average());
                LearningStatistics.MSE.Add(currentEpochErrorsMSE.Average());
                learningData.Mix();
            } while (LearningStatistics.MSE.Last() > limit);
        }

        public void Learn_Backpropogation(LearningData learningData, int times, double learningRate = 0.1)
        {
            for (int i = 0; i < times; i++)
            {
                var currentEpochErrorsMAE = new List<double>();
                var currentEpochErrorsMSE = new List<double>();
                for (int j = 0; j < learningData.LearningExamples.Count; j++)
                {
                    LearningExample example = learningData.LearningExamples[j];
                    Learn_RecalculateError(example.InputSignals, example.ExpectedOutputs);
                    Learn_ChangeWeights(learningRate);
                    currentEpochErrorsMAE.Add(Math.Abs(Layers.Last().Neurons.Last().Error));
                    currentEpochErrorsMSE.Add(Math.Pow(Layers.Last().Neurons.Last().Error, 2));
                }
                LearningStatistics.MAE.Add(currentEpochErrorsMAE.Average());
                LearningStatistics.MSE.Add(currentEpochErrorsMSE.Average());
                learningData.Mix();
            }
        }

        private void Learn_RecalculateError(List<double> inputSignals, List<double> expectedOutputs)
        {
            List<double> actualResultFull = Predict_ReturnOnlyValues(inputSignals);
            for (int i = 0; i < Layers.Last().Neurons.Count; i++)
            {
                var neuron = Layers.Last().Neurons[i];
                var expectedOutput = (expectedOutputs[i] - neuron.Min) / (neuron.Max - neuron.Min);
                var actualResult = actualResultFull[i];
                Layers.Last().Neurons[i].Error = expectedOutput - actualResult;
            }
                

            for (int i = Layers.Count - 2; i > 0; i--)
            {
                Layer currentLayer = Layers[i];
                Layer previousRightLayer = Layers[i + 1];
                for (int j = 0; j < currentLayer.Neurons.Count; j++)
                {
                    if (currentLayer.Neurons[j].NeuronType == Structure.NeuronType.Bias)
                        continue;

                    double sumResultError = 0;
                    for (int k = 0; k < previousRightLayer.Neurons.Count; k++)
                    {
                        if (previousRightLayer.Neurons[k].NeuronType == Structure.NeuronType.Bias)
                            continue;
                        sumResultError += previousRightLayer.Neurons[k].Error * previousRightLayer.Neurons[k].Weights[j];
                    }                      
                    currentLayer.Neurons[j].Error = sumResultError;
                }
            }
        }

        private void Learn_ChangeWeights(double learningRate)
        {
            for (int i = Layers.Count - 1; i > 0; i--)
                for (int j = Layers[i].Neurons.Count - 1; j >= 0; j--)
                    Layers[i].Neurons[j].Learn_ChangeWeights(learningRate);
        }

        public void Learn_Clear()
        {
            foreach (Layer layer in Layers)
                foreach (Neuron neuron in layer.Neurons)
                {
                    neuron.Error = 0;
                    neuron.Output = 0;
                    neuron.Sum = 0;
                    for (int i = 0; i < neuron.Inputs.Count; i++)
                        neuron.Inputs[i] = 0;
                }
        }
        #endregion

        #region НормализацияМаштабирование
        public void Normalization(LearningData learningData)
        {
            for (int i = 0; i < Layers.First().Neurons.Count; i++)
            {
                if (Layers.First().Neurons[i].NeuronType == Structure.NeuronType.Bias)
                    continue;

                var column = learningData.LearningExamples.Select(item => item.InputSignals[i]).ToList();
                column.Sort();
                Layers.First().Neurons[i].Min = column.First();
                Layers.First().Neurons[i].Max = column.Last();
                if (learningData.ParamNamesInput != null)
                    Layers.First().Neurons[i].Name = learningData.ParamNamesInput[i];
            } //нормализация входного слоя

            for (int i = 0; i < Layers.Last().Neurons.Count; i++)
            {
                var column = learningData.LearningExamples.Select(item => item.ExpectedOutputs[i]).ToList();
                column.Sort();
                Layers.Last().Neurons[i].Min = column.First();
                Layers.Last().Neurons[i].Max = column.Last();
                if (learningData.ParamNamesOutput != null)
                    Layers.Last().Neurons[i].Name = learningData.ParamNamesOutput[i];
            } //выходного слоя
        }
        #endregion
    }
}
