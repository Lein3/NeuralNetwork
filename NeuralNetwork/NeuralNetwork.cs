using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class NeuralNetwork
    {
        public Structure Structure { get; }
        public List<Layer> Layers { get; }

        public NeuralNetwork(Structure temp_Structure)
        {
            Structure = temp_Structure;
            Layers = new List<Layer>();
            CreateInputLayer();
            CreateMiddleLayers();
            CreateOutputLayer();
        }

        #region РасчетыОтвета
        public List<Tuple<string, double, double>> Predict(List<double> inputSignals)
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

        #region Обучение
        public void Learn(LearningData learningData, int times, double learningRate = 0.1)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < learningData.Examples.Count; j++)
                {
                    LearningExample example = learningData.Examples[j];
                    Learn_RecalculateError(example.InputSignals, example.ExpectedOutputs);
                    Learn_ChangeWeights(learningRate);
                }
                learningData.Mix();
            }
        }

        private void Learn_RecalculateError(List<double> inputSignals, List<double> expectedOutputs)
        {
            List<double> actualResult = Predict_ReturnOnlyValues(inputSignals);
            for (int i = 0; i < Layers.Last().Neurons.Count; i++)
                Layers.Last().Neurons[i].Error = expectedOutputs[i] - actualResult[i];

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
            //double lastError = Math.Pow((expectedResult - actualResult), 2);
            //var sumWeights = 0.0;
            //for (int l = 0; l < previousRightLayer.neurons[k].weights.Count; l++)
            //    sumWeights += previousRightLayer.neurons[k].weights[l];
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

                var column = learningData.Examples.Select(item => item.InputSignals[i]).ToList();
                column.Sort();
                Layers.First().Neurons[i].Min = column.First();
                Layers.First().Neurons[i].Max = column.Last();
                Layers.First().Neurons[i].Name = learningData.ParamNamesInput[i];
            } //нормализация входного слоя

            for (int i = 0; i < Layers.Last().Neurons.Count; i++)
            {
                var column = learningData.Examples.Select(item => item.ExpectedOutputs[i]).ToList();
                column.Sort();
                Layers.Last().Neurons[i].Min = column.First();
                Layers.Last().Neurons[i].Max = column.Last();
                Layers.Last().Neurons[i].Name = learningData.ParamNamesOutput[i];
            } //выходного слоя
        }
        #endregion
    }
}
