using System;
using System.Collections.Generic;


namespace NeuralNetworkNamespace
{
    public abstract class Neuron
    {
        public List<double> Weights { get; set; }
        public List<double> Inputs { get; set; }
        public Structure.NeuronType NeuronType { get; set; }
        public enum ActivationFunctionEnum { None, ELU, Linear, LReLU, ReLu, Sigmoid, Softmax, Th, Threshold };
        public IActivationFunction ActivationFunction { get; set; }
        public double Sum { get; set; }
        public double Output { get; set; }
        public double Error { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public string Name { get; set; }
        protected static Random Rnd { get; set; } = new Random(DateTime.Now.Millisecond); //рандом не трожь все посыпется к чертям

        public Neuron(ActivationFunctionEnum function)
        {           
            Weights = new List<double>();
            Inputs = new List<double>();
            Min = 0;
            Max = 1;
            SetActivationFunction(function);
        }

        public abstract double ProcessInformation(List<double> original_inputs);

        public abstract void Learn_ChangeWeights(double learningRate);

        public void SetActivationFunction(ActivationFunctionEnum function)
        {
            switch (function)
            {
                case ActivationFunctionEnum.None:
                    ActivationFunction = new None();
                    break;
                case ActivationFunctionEnum.ELU:
                    ActivationFunction = null;
                    break;
                case ActivationFunctionEnum.Linear:
                    ActivationFunction = new Linear();
                    break;
                case ActivationFunctionEnum.LReLU:
                    ActivationFunction = new LReLU();
                    break;
                case ActivationFunctionEnum.Sigmoid:
                    ActivationFunction = new Sigmoid();
                    break;
                case ActivationFunctionEnum.Softmax:
                    ActivationFunction = new Softmax();
                    break;
                case ActivationFunctionEnum.Th:
                    ActivationFunction = null;
                    break;
                case ActivationFunctionEnum.Threshold:
                    ActivationFunction = null;
                    break;
                default:
                    ActivationFunction = null;
                    break;
            }
        }
    }
}
