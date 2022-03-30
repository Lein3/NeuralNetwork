using System;
using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public class Neuron
    {
        public List<double> weights { get; }
        public List<double> inputs { get; set; }
        public Structure.NeuronType neuronType { get; }
        public double output { get; set; }
        public double error { get; set; }
        public double sum { get; set; }
        public double? max { get; set; } = 1;
        public double? min { get; set; } = 0;       

        public Neuron(int temp_previousLayerNeuronsCount, Structure.NeuronType temp_neuronType)
        {
            neuronType = temp_neuronType;
            weights = new List<double>();
            inputs = new List<double>();
            Random rnd = new Random(new Guid().GetHashCode());

            for (int i = 0; i < temp_previousLayerNeuronsCount; i++)
            {
                if (neuronType == Structure.NeuronType.Input)
                    weights.Add(1);
                else
                    weights.Add(rnd.NextDouble() * 2 - 1);
                inputs.Add(0);
            }
        }

        public double ProcessInformation(List<double> original_inputs)
        {
            for (int i = 0; i < original_inputs.Count; i++)
            {
                if (neuronType == Structure.NeuronType.Input)
                    inputs[i] = Convert.ToDouble((original_inputs[i] - min) / (max - min));
                else
                    inputs[i] = original_inputs[i];
            }

            sum = 0;
            for (int i = 0; i < inputs.Count; i++)
                sum += inputs[i] * weights[i];

            if (neuronType != Structure.NeuronType.Input)
                output = Sigmoid(sum);
            else
                output = sum;
            return output;
        }

        public void Learn_ChangeWeights(double learningRate)
        {
            if (neuronType == Structure.NeuronType.Input)
                return;
            for (int i = 0; i < weights.Count; i++)
            {
                double new_weight = weights[i] - learningRate * (-error * SigmoidDx(sum) * inputs[i]); 
                weights[i] = new_weight;
            }
        }

        private double Sigmoid(double x)
        {
            double result = 1 / (1 + Math.Exp(-x));
            return result;
        }

        private double SigmoidDx(double x)
        {
            double result = Sigmoid(x) * (1 - Sigmoid(x));
            return result;
        }
    }
}
