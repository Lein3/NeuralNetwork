using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    public interface ICostFunction
    {
        double CalculateError(double expected, double actual);
    }
}
