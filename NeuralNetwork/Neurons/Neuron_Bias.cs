using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class NeuronBias : Neuron
    {
        public NeuronBias() : base(ActivationFunctionEnum.None)
        {
            NeuronType = Structure.NeuronType.Bias;
        }

        public override double ProcessInformation(List<double> originalInputs)
        {
            return 1;
        }

        public override void Learn_ChangeWeights(double learningRate)
        {
            return;
        }
    }
}
