namespace NeuralNetworkNamespace
{
    public class Softmax : IActivationFunction
    {
        public double Function(double x)
        {
            return x;
        }

        public double Derivative(double x)
        {
            return x * (1 - x);
        }
    }
}