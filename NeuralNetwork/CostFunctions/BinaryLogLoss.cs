using System;

namespace NeuralNetworkNamespace
{
    internal class BinaryLogLoss : ICostFunction
    {
        public double Function(double expected, double actual)
        {
            return -expected * Math.Log(actual) - (1 - expected) * Math.Log(1 - actual);
        }

        public double Derivative(IActivationFunction activationFunction, double activationInput, double expected, double actual)
        {
            return -expected / activationFunction.Function(activationInput) * activationFunction.Derivative(activationInput) + (1 - expected) / (1 - activationFunction.Function(activationInput)) * activationFunction.Derivative(activationInput);
        }
    }
}
