using System;

namespace NeuralNetworkNamespace
{
    internal class LReLu : IActivationFunction
    {
        public double Function(double input)
        {
            return Math.Max(0.01 * input, input);
        }

        public double Derivative(double input)
        {
            if (input < 0)
                return 0.01;
            else
                return 1;
        }
    }
}
