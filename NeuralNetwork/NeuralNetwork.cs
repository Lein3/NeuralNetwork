using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class NeuralNetwork
    {
        public Structure structure { get; }
        public List<Layer> layers { get; }

        public NeuralNetwork(Structure temp_Structure)
        {
            structure = temp_Structure;
            layers = new List<Layer>();
            CreateInputLayer();
            CreateMiddleLayers();
            CreateOutputLayer();
        }

        #region РасчетыОтвета
        public List<Tuple<string, double, double>> Predict(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return layers.Last().GetAnswer();
        }

        public List<double> Predict_ReturnOnlyValues(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return layers.Last().GetSignals();
        }

        private void SendSignalsToInputLayer(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; i++)
            {
                List<double> signal = new List<double> { inputSignals[i] };
                layers.First().neurons[i].ProcessInformation(signal);
            }
        }

        private void SendSignalsAfterInputLayer()
        {
            for (int i = 1; i < layers.Count; i++)
            {
                Layer layer = layers[i];
                List<double> previousLayerSignals = layers[i - 1].GetSignals();
                foreach (Neuron neuron in layer.neurons)
                    neuron.ProcessInformation(previousLayerSignals);
            }
        }
        #endregion

        #region СозданиеСлоев
        private void CreateInputLayer()
        {
            List<Neuron> inputNeurons = new List<Neuron>();
            for (int i = 0; i < structure.inputNeuronsCount; i++)
            {
                Neuron neuron = new Neuron(1, Structure.NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            if (structure.bias)
            {
                Neuron bias = new Neuron(1, Structure.NeuronType.Bias);
                inputNeurons.Add(bias);
            }
            Layer inputLayer = new Layer(inputNeurons);
            layers.Add(inputLayer);
        }

        private void CreateMiddleLayers()
        {
            for (int i = 0; i < structure.middleLayers.Count; i++)
            {
                List<Neuron> middleNeurons = new List<Neuron>();
                Layer lastLayerNeuronCount = layers.Last();
                for (int j = 0; j < structure.middleLayers[i]; j++)
                {
                    Neuron neuron = new Neuron(lastLayerNeuronCount.neurons.Count, Structure.NeuronType.Normal);
                    middleNeurons.Add(neuron);
                }
                if (structure.bias)
                {
                    Neuron bias = new Neuron(1, Structure.NeuronType.Bias);
                    middleNeurons.Add(bias);
                }
                Layer middleLayer = new Layer(middleNeurons);
                layers.Add(middleLayer);
            }
        }

        private void CreateOutputLayer()
        {
            List<Neuron> outputNeurons = new List<Neuron>();
            Layer lastLayerNeuronCount = layers.Last();
            for (int i = 0; i < structure.outputNeuronsCount; i++)
            {
                Neuron neuron = new Neuron(lastLayerNeuronCount.neurons.Count, Structure.NeuronType.Output);
                outputNeurons.Add(neuron);
            }
            Layer outputLayer = new Layer(outputNeurons);
            layers.Add(outputLayer);
        }
        #endregion

        #region Обучение
        public void Learn(LearningData learningData, int times, double learningRate = 0.1)
        {
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < learningData.examples.Count; j++)
                {
                    LearningExample example = learningData.examples[j];
                    Learn_RecalculateError(example.inputSignals, example.expectedOutputs);
                    Learn_ChangeWeights(learningRate);
                }
                learningData.Mix();
            }
        }

        private void Learn_RecalculateError(List<double> inputSignals, List<double> expectedOutputs)
        {
            List<double> actualResult = Predict_ReturnOnlyValues(inputSignals);
            for (int i = 0; i < layers.Last().neurons.Count; i++)
                layers.Last().neurons[i].error = expectedOutputs[i] - actualResult[i];

            for (int i = layers.Count - 2; i > 0; i--)
            {
                Layer currentLayer = layers[i];
                Layer previousRightLayer = layers[i + 1];
                for (int j = 0; j < currentLayer.neurons.Count; j++)
                {
                    if (currentLayer.neurons[j].neuronType == Structure.NeuronType.Bias)
                        continue;

                    double sumResultError = 0;
                    for (int k = 0; k < previousRightLayer.neurons.Count; k++)
                    {
                        if (previousRightLayer.neurons[k].neuronType == Structure.NeuronType.Bias)
                            continue;
                        sumResultError += previousRightLayer.neurons[k].error * previousRightLayer.neurons[k].weights[j];
                    }                      
                    currentLayer.neurons[j].error = sumResultError;
                }
            }
            //double lastError = Math.Pow((expectedResult - actualResult), 2);
            //var sumWeights = 0.0;
            //for (int l = 0; l < previousRightLayer.neurons[k].weights.Count; l++)
            //    sumWeights += previousRightLayer.neurons[k].weights[l];
        }

        private void Learn_ChangeWeights(double learningRate)
        {
            for (int i = layers.Count - 1; i > 0; i--)
                for (int j = layers[i].neurons.Count - 1; j >= 0; j--)
                    layers[i].neurons[j].Learn_ChangeWeights(learningRate);
        }

        public void Learn_Clear()
        {
            foreach (Layer layer in layers)
                foreach (Neuron neuron in layer.neurons)
                {
                    neuron.error = 0;
                    neuron.output = 0;
                    neuron.sum = 0;
                    for (int i = 0; i < neuron.inputs.Count; i++)
                        neuron.inputs[i] = 0;
                }
        }
        #endregion

        #region НормализацияМаштабирование
        public void Normalization(LearningData learningData)
        {
            for (int i = 0; i < layers.First().neurons.Count; i++)
            {
                if (layers.First().neurons[i].neuronType == Structure.NeuronType.Bias)
                    continue;

                var column = learningData.examples.Select(item => item.inputSignals[i]).ToList();
                column.Sort();
                layers.First().neurons[i].min = column.First();
                layers.First().neurons[i].max = column.Last();
                layers.First().neurons[i].name = learningData.paramNamesInput[i];
            } //нормализация входного слоя

            for (int i = 0; i < layers.Last().neurons.Count; i++)
            {
                var column = learningData.examples.Select(item => item.expectedOutputs[i]).ToList();
                column.Sort();
                layers.Last().neurons[i].min = column.First();
                layers.Last().neurons[i].max = column.Last();
                layers.Last().neurons[i].name = learningData.paramNamesOutput[i];
            } //выходного слоя
        }
        #endregion
    }
}
