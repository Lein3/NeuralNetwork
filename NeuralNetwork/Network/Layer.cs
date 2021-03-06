using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkNamespace
{
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }

        public Layer()
        {

        }

        public Layer(List<Neuron> temp_Neurons)
        {
            Neurons = temp_Neurons;
        }

        public Layer(Structure.NeuronType neuronType, int previousLayerNeuronsCount, int currentLayerNeuronsCount, bool bias = false)
        {
            Neurons = new List<Neuron>();
            for (int i = 0; i < currentLayerNeuronsCount; i++)
            {
                switch (neuronType)
                {
                    case Structure.NeuronType.Input:
                        Neuron neuronInput = new Neuron_Input();
                        Neurons.Add(neuronInput);
                        break;
                    case Structure.NeuronType.Normal:
                        Neuron neuronNormal = new Neuron_Normal(previousLayerNeuronsCount);
                        Neurons.Add(neuronNormal);
                        break;
                    case Structure.NeuronType.Output:
                        Neuron neuronOutput = new Neuron_Output(previousLayerNeuronsCount);
                        Neurons.Add(neuronOutput);
                        break;
                }             
            }
            if (bias == true && neuronType != Structure.NeuronType.Output)
            {
                Neuron neuron = new Neuron_Bias();
                Neurons.Add(neuron);
            }
        }

        public Layer(LearningData learningData, bool bias = false)
        {
            Neurons = new List<Neuron>();
            for (int i = 0; i < learningData.ParamNamesInput.Count; i++)
            {
                Neuron neuron = new Neuron_Input();
                neuron.Name = learningData.ParamNamesInput[i];

                var column = learningData.LearningExamples.Select(item => item.InputSignals[i]).ToList();
                column.Sort();
                neuron.Min = column.Min();
                neuron.Max = column.Max();
                Neurons.Add(neuron);
            }
            if (bias == true)
            {
                Neuron neuron = new Neuron_Bias();
                Neurons.Add(neuron);
            }
        }

        public void CalculateError(List<double> expectedOutputs, ICostFunction costFunction) //расчет на последнем слое
        {
            for (int i = 0; i < Neurons.Count; i++)
            {
                var neuron = Neurons[i];
                var expectedOutput = (expectedOutputs[i] - neuron.Min) / (neuron.Max - neuron.Min);
                var actualResult = neuron.Output;
                var costDerivative = costFunction.Derivative(neuron.ActivationFunction, neuron.Sum, expectedOutput, actualResult);
                var activationDerivative = neuron.ActivationFunction.Derivative(neuron.Sum);
                var error = costDerivative * activationDerivative;
                neuron.Error = error;
            }
        }

        public void CalculateError(Layer previousRightLayer) //расчет на скрытых слоях
        {
            for (int i = 0; i < Neurons.Count; i++)
            {
                var currentNeuron = Neurons[i];
                if (currentNeuron.NeuronType == Structure.NeuronType.Bias)
                    continue;

                double sumResultError = 0;
                for (int j = 0; j < previousRightLayer.Neurons.Count; j++)
                {
                    var previousRightNeuron = previousRightLayer.Neurons[j];
                    if (previousRightNeuron.NeuronType == Structure.NeuronType.Bias)
                        continue;

                    sumResultError += previousRightNeuron.Error * previousRightNeuron.Weights[i];
                }
                currentNeuron.Error = sumResultError * currentNeuron.ActivationFunction.Derivative(currentNeuron.Sum);
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
