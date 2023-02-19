using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace NeuralNetworkNamespace
{
    public abstract class Neuron
    {
        public List<double> Weights { get; set; }
        [JsonIgnore]
        public List<double> Inputs { get; set; }
        public Structure.NeuronType NeuronType { get; set; }
        public enum ActivationFunctionEnum { None, Elu, Linear, LReLu, ReLu, Sigmoid, Softmax, Th, Threshold };
        public IActivationFunction ActivationFunction { get; set; }
        [JsonIgnore]
        public double Sum { get; set; }
        [JsonIgnore]
        public double Output { get; set; }
        [JsonIgnore]
        public double Error { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        protected static Random Rnd { get; set; } = new Random(DateTime.Now.Millisecond); //рандом не трожь все посыпется к чертям

        protected Neuron(ActivationFunctionEnum function)
        {
            Weights = new List<double>();
            Inputs = new List<double>();
            Min = 0;
            Max = 1;
            SetActivationFunction(function);
        }

        public abstract double ProcessInformation(List<double> originalInputs);

        public abstract void Learn_ChangeWeights(double learningRate);

        public void SetActivationFunction(ActivationFunctionEnum function)
        {
            switch (function)
            {
                case ActivationFunctionEnum.None:
                    ActivationFunction = new None();
                    break;
                case ActivationFunctionEnum.Elu:
                    ActivationFunction = null;
                    break;
                case ActivationFunctionEnum.Linear:
                    ActivationFunction = new Linear();
                    break;
                case ActivationFunctionEnum.LReLu:
                    ActivationFunction = new LReLu();
                    break;
                case ActivationFunctionEnum.Sigmoid:
                    ActivationFunction = new Sigmoid();
                    break;
                case ActivationFunctionEnum.Softmax:
                    ActivationFunction = new Softmax();
                    break;

                case ActivationFunctionEnum.Th:
                case ActivationFunctionEnum.Threshold:
                case ActivationFunctionEnum.ReLu:
                default:
                    ActivationFunction = null;
                    break;
            }
        }
    }
}
