using System;

namespace NeuralNetworkNamespace
{
    internal class SquaredError : ICostFunction
    {
        public double Function(double expected, double actual)
        {
            return Math.Pow(expected - actual, 2);
        }

        public double Derivative(IActivationFunction activationFunction, double activationInput, double expected, double actual)
        {
            return 2 * (activationFunction.Function(activationInput) - actual) * activationFunction.Derivative(activationInput);
        }
    }
}
