using System;

namespace NeuralNetworkNamespace
{
    public class CategoryLogLoss : ICostFunction
    {
        public double Function(double expected, double actual)
        {
            return -expected * Math.Log(actual);
        }

        public double Derivative(IActivationFunction activationFunction, double activationInput, double expected, double actual)
        {
            return actual - expected;
        }
    }
}
