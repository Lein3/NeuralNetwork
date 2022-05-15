namespace NeuralNetworkNamespace
{
    public interface IActivationFunction
    {
        double Function(double input);

        double Derivative(double input);
    }
}
