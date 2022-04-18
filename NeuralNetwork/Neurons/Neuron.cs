using System;
using System.Collections.Generic;

namespace NeuralNetwork
{
    [Serializable]
    public abstract class Neuron
    {
        public List<double> Weights { get; }
        public List<double> Inputs { get; set; }
        public Structure.NeuronType NeuronType { get; set; }
        public IActivationFunction ActivationFunction { get; set; }
        public double Output { get; set; }
        public double Error { get; set; }
        public double Sum { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public string Name { get; set; }
        protected static Random Rnd { get; set; } = new Random(DateTime.Now.Millisecond); //сука рандом не трожь все по пизде пойдет

        public Neuron()
        {           
            Weights = new List<double>();
            Inputs = new List<double>();
            Min = 0;
            Max = 1;
            ActivationFunction = new Sigmoid();
        }

        public abstract double ProcessInformation(List<double> original_inputs);

        public abstract void Learn_ChangeWeights(double learningRate);
    }
}
