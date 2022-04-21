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

        public List<(string Name, double Output, double NormalizedOutput)> GetAnswer()
        {
            var answer = new List<(string Name, double Output, double NormalizedOutput)>();
            foreach (Neuron neuron in Neurons)
            {
                var normalizedOutput = neuron.Output * (neuron.Max - neuron.Min) + neuron.Min;
                normalizedOutput = Math.Round(normalizedOutput);
                var valueTuple = (neuron.Name, neuron.Output, normalizedOutput);
                answer.Add(valueTuple);
            }
            return answer;
        }
    }
}
