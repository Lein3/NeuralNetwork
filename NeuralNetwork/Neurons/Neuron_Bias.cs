using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class Neuron_Bias : Neuron
    {
        public Neuron_Bias() : base()
        {
            NeuronType = Structure.NeuronType.Bias;
        }

        public override double ProcessInformation(List<double> original_inputs)
        {
            return 1;
        }

        public override void Learn_ChangeWeights(double learningRate)
        {
            return;
        }
    }
}
