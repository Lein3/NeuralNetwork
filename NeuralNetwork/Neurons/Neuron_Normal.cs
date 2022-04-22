﻿using System;
using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class Neuron_Normal : Neuron
    {
        public Neuron_Normal(int temp_previousLayerNeuronsCount) : base()
        {
            NeuronType = Structure.NeuronType.Normal;
            for (int i = 0; i < temp_previousLayerNeuronsCount; i++)
            {
                Weights.Add(Rnd.NextDouble() * 2 - 1);
                Inputs.Add(0);
            }
        }

        public override double ProcessInformation(List<double> original_inputs)
        {
            Inputs = new List<double>(original_inputs);
            Sum = 0;
            for (int i = 0; i < Inputs.Count; i++)
                Sum += Inputs[i] * Weights[i];

            Output = ActivationFunction.Function(Sum);
            return Output;
        }

        public override void Learn_ChangeWeights(double learningRate)
        {
            for (int i = 0; i < Weights.Count; i++)
            {
                double new_weight = Weights[i] + (learningRate * Error * ActivationFunction.FunctionDx(Sum) * Inputs[i]);
                Weights[i] = new_weight;
            }
        }
    }
}
