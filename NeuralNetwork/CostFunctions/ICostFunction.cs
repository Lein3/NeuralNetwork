using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    public interface ICostFunction
    {
        void Function();
        double Derivative(double expected, double actual, int n = 1);
    }
}
