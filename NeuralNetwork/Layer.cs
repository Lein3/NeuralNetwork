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

        public Dictionary<string, double> GetAnswer()
        {
            Dictionary<string, double> answer = new Dictionary<string,double>();
            foreach (Neuron neuron in neurons)
                answer.Add(neuron.name, neuron.output);
            return answer;
        }
    }
}
