using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    internal class None : IActivationFunction
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
