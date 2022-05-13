using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    internal class Default : ICostFunction
    {
        public double CalculateError(double expected, double actual)
        {
            return expected - actual;
        }
    }
}
