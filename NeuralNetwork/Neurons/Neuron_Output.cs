using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class NeuronOutput : Neuron
    {
        public NeuronOutput(int tempPreviousLayerNeuronsCount, ActivationFunctionEnum function = ActivationFunctionEnum.Sigmoid) : base(function)
        {
            NeuronType = Structure.NeuronType.Output;
            for (int i = 0; i < tempPreviousLayerNeuronsCount; i++)
            {
                Weights.Add(Rnd.NextDouble() * 2 - 1);
                Inputs.Add(0);
            }
        }

        public override double ProcessInformation(List<double> originalInputs)
        {
            Inputs = new List<double>(originalInputs);
            Sum = 0;
            for (int i = 0; i < Inputs.Count; i++)
                Sum += Inputs[i] * Weights[i];

            Output = ActivationFunction.Function(Sum);
            return Output;
        }

        public override void Learn_ChangeWeights(double learningRate)
        {
            for (int i = 0; i < Weights.Count; i++)
            {
                double newWeight = Weights[i] + (learningRate * -Error * Inputs[i]);
                Weights[i] = newWeight;
            }
        }
    }
}
