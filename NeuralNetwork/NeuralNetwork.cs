using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public double Predict(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            if (structure.outputNeuronsCount == 1)
                return layers.Last().neurons[0].output;
            else
                return layers.Last().neurons.OrderByDescending(n => n.output).FirstOrDefault().output;
        }

        private void SendSignalsToInputLayer(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; i++)
            {
                List<double> signal = new List<double> { inputSignals[i] };
                layers[0].neurons[i].ProcessInformation(signal);
            }
        }

        private void SendSignalsAfterInputLayer()
        {
            for (int i = 1; i < layers.Count; i++)
            {
                Layer layer = layers[i];
                List<double> previousLayerSignals = layers[i - 1].GetSignals();
                foreach (var neuron in layer.neurons)
                    neuron.ProcessInformation(previousLayerSignals);
            }
        }

        private void CreateInputLayer()
        {
            List<Neuron> inputNeurons = new List<Neuron>();
            for (int i = 0; i < structure.inputNeuronsCount; i++)
            {
                Neuron neuron = new Neuron(1, Structure.NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            Layer inputLayer = new Layer(inputNeurons, Structure.NeuronType.Input);
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
                Layer middleLayer = new Layer(middleNeurons, Structure.NeuronType.Normal);
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
            Layer outputLayer = new Layer(outputNeurons, Structure.NeuronType.Output);
            layers.Add(outputLayer);
        }

        public void Learn(List<double> expected, List<double[]> inputs, double learningRate)
        {
            for (int i = 0; i < expected.Count; i++)
            {
                Learn_RecalculateError(expected[i], inputs[i].ToList());
                Learn_BackPropagation(learningRate);
            }
        }

        private void Learn_RecalculateError(double expectedResult, List<double> inputSignals)
        {
            double actualResult = Predict(inputSignals);
            double lastError = expectedResult - actualResult;
            if (structure.outputNeuronsCount == 1)
                layers.Last().neurons[0].delta = lastError;
            for (int i = layers.Count - 2; i > 0; i--)
            {
                Layer currentLayer = layers[i];
                Layer previousLayer = layers[i + 1];
                for (int j = 0; j < currentLayer.neurons.Count; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < previousLayer.neurons.Count; k++)
                        sum += previousLayer.neurons[k].delta * previousLayer.neurons[k].weights[j];
                    currentLayer.neurons[j].delta = sum;
                }
            }
        }

        private void Learn_BackPropagation(double learningRate)
        {
            for (int i = 1; i < layers.Count; i++)
                for (int j = 0; j < layers[i].neurons.Count; j++)
                    layers[i].neurons[j].Learn(learningRate);
        }

        public void Scalling(List<double[]> inputs)
        {
            for (int i = 0; i < inputs.First().Length; i++)
            {
                List<double> column = new List<double>();
                for (int j = 0; j < inputs.Count; j++)
                {
                    List<double> row = inputs[j].ToList();
                    column.Add(row[i]);
                }
                column.Sort();
                layers[0].neurons[i].min = column.First();
                layers[0].neurons[i].max = column.Last();
            }
        }

        public void Read_Scalling_Learn(string path, int times, double learningRate)
        {
            List<double[]> inputs = new List<double[]>();
            List<double> outputs = new List<double>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    List<double> values = streamReader.ReadLine().Split(',').ToList().ConvertAll(a => Convert.ToDouble(a.Replace('.', ',')));
                    inputs.Add(values.Take(values.Count - 1).ToArray());
                    outputs.Add(values.Last());
                }
            }
            Scalling(inputs);
            for (int i = 0; i < times; i++)
                Learn(outputs, inputs, learningRate);
        }
    }
}
