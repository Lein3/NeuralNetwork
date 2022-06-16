using System;

namespace NeuralNetworkNamespace
{
    internal class BinaryLogLoss : ICostFunction
    {
        public double Function(double expected, double actual)
        {
            var result = -expected * Math.Log(actual) - (1 - expected) * Math.Log(1 - actual);

            if (result is double.NaN) //nan получается если нам приходит 1 и 1 из за того что он считает log по нулю. по факту между 1 и 1 ошибка нулевая значит вернуть 0
                return 0;
            else
                return result;
        }

        public double Derivative(IActivationFunction activationFunction, double activationInput, double expected, double actual)
        {
            var result = -expected / activationFunction.Function(activationInput) * activationFunction.Derivative(activationInput) + (1 - expected) / (1 - activationFunction.Function(activationInput)) * activationFunction.Derivative(activationInput);

            if (result is double.NaN)
                return 0;
            else
                return result;
        }
    }
}
