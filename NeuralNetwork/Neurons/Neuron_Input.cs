using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class Neuron_Input : Neuron
    {
        public Neuron_Input(FunctionsEnum function = FunctionsEnum.None) : base(function)
        {
            NeuronType = Structure.NeuronType.Input;
            Weights.Add(1);
            Inputs.Add(0);
        }

        public override double ProcessInformation(List<double> original_inputs)
        {
            for (int i = 0; i < original_inputs.Count; i++)
                Inputs[i] = Convert.ToDouble((original_inputs[i] - Min) / (Max - Min));

            Sum = 0;
            for (int i = 0; i < Inputs.Count; i++)
                Sum += Inputs[i] * Weights[i];

            Output = Sum;
            return Output;
        }

        public override void Learn_ChangeWeights(double learningRate)
        {
            return;
        }
    }
}
