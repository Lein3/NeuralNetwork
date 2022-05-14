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

        public double Derivative(double expected, double actual, int n = 1)
        {
            return -2 / n * (expected - actual); //https://mattmazur.com/2015/03/17/a-step-by-step-backpropagation-example/
        }
    }
}
