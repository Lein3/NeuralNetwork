using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class LayerSoftMax : Layer
    {
        public LayerSoftMax(int previousLayerNeuronsCount, int currentLayerNeuronsCount)
        {
            Neurons = new List<Neuron>();
            for (int i = 0; i < currentLayerNeuronsCount; i++)
            {
                Neuron neuronOutput = new Neuron_Output(previousLayerNeuronsCount, Neuron.ActivationFunctionEnum.Sigmoid);
                Neurons.Add(neuronOutput);
            }
        }

        public void ProcessInformation()
        {
            double sum = 0;
            foreach (var neuron in Neurons)
            {
                sum += Math.Exp(neuron.Sum);
            }
            foreach (var neuron in Neurons)
            {
                neuron.Output = Math.Exp(neuron.Sum) / sum;
            }
        }
    }
}
