using System;
using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class Layer
    {
        public List<Neuron> neurons { get; }

        public Layer(List<Neuron> temp_Neurons)
        {
            neurons = temp_Neurons;
        }

        public List<double> GetSignals()
        {
            List<double> result = new List<double>();
            foreach (Neuron neuron in neurons)
                result.Add(neuron.output);
            return result;
        }

        public List<Tuple<string, double, double>> GetAnswer()
        {
            List<Tuple<string, double, double>> answer = new List<Tuple<string, double, double>>();
            foreach (Neuron neuron in neurons)
            {
                var normalizedOutput = neuron.output * (neuron.max - neuron.min) + neuron.min;
                normalizedOutput = Math.Round(normalizedOutput);
                var tuple = new Tuple<string, double, double>(neuron.name, neuron.output, normalizedOutput);
                answer.Add(tuple);
            }
            return answer;
        }
    }
}
