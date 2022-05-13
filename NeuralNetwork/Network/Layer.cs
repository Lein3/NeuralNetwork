using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    [Serializable]
    public class Layer
    {
        public List<Neuron> Neurons { get; private set; }
        public ICostFunction CostFunction { get; private set; }

        public Layer(List<Neuron> temp_Neurons)
        {
            Neurons = temp_Neurons;
        }

        public void CalculateError(List<double> expectedOutputs)
        {
            for (int i = 0; i < Neurons.Count; i++)
            {
                var neuron = Neurons[i];
                var expectedOutput = (expectedOutputs[i] - neuron.Min) / (neuron.Max - neuron.Min);
                var actualResult = neuron.Output;
                neuron.Error = CostFunction.CalculateError(expectedOutput, actualResult);
            }
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
