using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkNamespace
{
    public interface IActivationFunction
    {
        double Function(double input);

        double FunctionDx(double input);
    }
}
