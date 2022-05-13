using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    internal class LReLU : IActivationFunction
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
