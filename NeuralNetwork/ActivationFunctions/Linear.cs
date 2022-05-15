namespace NeuralNetworkNamespace
{
    public class Linear : IActivationFunction
    {
        public double Function(double input)
        {
            return input;
        }

        public double Derivative(double input)
        {
            return 1;
        }
    }
}
