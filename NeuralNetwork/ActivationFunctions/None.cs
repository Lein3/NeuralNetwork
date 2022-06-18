using System;

namespace NeuralNetworkNamespace
{
    public class None : IActivationFunction
    {
        public double Function(double input)
        {
            throw new NotImplementedException();
        }

        public double Derivative(double input)
        {
            throw new NotImplementedException();
        }
    }
}
