using System;

namespace NeuralNetworkNamespace
{
    internal class ReLu : IActivationFunction
    {
        public double Function(double input)
        {
            return Math.Max(0, input);
        }

        public double Derivative(double input)
        {
            if (input < 0)
                return 0;
            else
                return 1;
        }
    }
}
