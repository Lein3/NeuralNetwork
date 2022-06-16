using System;

namespace NeuralNetworkNamespace
{
    public class Sigmoid : IActivationFunction
    {
        public double Function(double x)
        {
            double result = 1 / (1 + Math.Exp(-x));

            if (result == 1)
                return result - 0.0001;
            else if (result == 0)
                return result + 0.0001;
            else
                return result;
        }

        public double Derivative(double x)
        {
            double result = Function(x) * (1 - Function(x));
            return result;
        }
    }
}
