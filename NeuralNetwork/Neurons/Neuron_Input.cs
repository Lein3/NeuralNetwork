using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class NeuronInput : Neuron
    {
        public NeuronInput(ActivationFunctionEnum function = ActivationFunctionEnum.None) : base(function)
        {
            NeuronType = Structure.NeuronType.Input;
            Weights.Add(1);
            Inputs.Add(0);
        }

        public override double ProcessInformation(List<double> originalInputs)
        {
            for (int i = 0; i < originalInputs.Count; i++)
                Inputs[i] = Convert.ToDouble((originalInputs[i] - Min) / (Max - Min));

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
