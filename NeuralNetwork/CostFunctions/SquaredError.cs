using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    internal class SquaredError : ICostFunction
    {
        public void Function()
        {
            throw new NotImplementedException();
        }

        public double Derivative(double expected, double actual)
        {
            return 2 * (expected - actual);
        }
    }
}
