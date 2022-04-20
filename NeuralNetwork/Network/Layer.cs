using System;
using System.Collections.Generic;

namespace NeuralNetwork
{
    [Serializable]
    public class Layer
    {
        public List<Neuron> Neurons { get; private set; }

        public Layer(List<Neuron> temp_Neurons)
        {
            Neurons = temp_Neurons;
        }

        public List<double> GetSignals()
        {
            List<double> result = new List<double>();
            foreach (Neuron neuron in Neurons)
                result.Add(neuron.Output);
            return result;
        }

        public List<Tuple<string, double, double>> GetAnswer()
        {
            List<Tuple<string, double, double>> answer = new List<Tuple<string, double, double>>();
            foreach (Neuron neuron in Neurons)
            {
                var normalizedOutput = neuron.Output * (neuron.Max - neuron.Min) + neuron.Min;
                normalizedOutput = Math.Round(normalizedOutput);
                var tuple = new Tuple<string, double, double>(neuron.Name, neuron.Output, normalizedOutput);
                answer.Add(tuple);
            }
            return answer;
        }
    }
}
