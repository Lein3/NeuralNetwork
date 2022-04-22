using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    public class Sigmoid : IActivationFunction
    {
        public double Function(double x)
        {
            double result = 1 / (1 + Math.Exp(-x));
            return result;
        }

        public double FunctionDx(double x)
        {
            double result = Function(x) * (1 - Function(x));
            return result;
        }
    }
}
