using System;
using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class Layer
    {
        public List<Neuron> neurons { get; }
        public Structure.NeuronType neuronType { get; }

        public Layer(List<Neuron> temp_Neurons, Structure.NeuronType temp_neuronType)
        {
            neurons = temp_Neurons;
            neuronType = temp_neuronType;
        }

        public List<double> GetSignals()
        {
            List<double> result = new List<double>();
            foreach (var neuron in neurons)
                result.Add(neuron.output);
            return result;
        }
    }
}
