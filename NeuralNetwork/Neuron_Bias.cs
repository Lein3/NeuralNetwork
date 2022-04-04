using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    public class Neuron_Bias : Neuron
    {
        public Neuron_Bias() : base()
        {
            NeuronType = Structure.NeuronType.Bias;
            Weights.Add(1);
            Inputs.Add(1);
            Sum = 1;
            Output = 1;
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
