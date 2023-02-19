using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace NeuralNetworkNamespace
{
    public class NeuralNetwork
    {
        public Structure Structure { get; private set; }
        public List<Layer> Layers { get; private set; }
        public enum CostFunctionEnum { AbsoluteError, BinaryLogLoss, CategoryLogLoss, SquaredError };
        public ICostFunction CostFunction { get; set; }
        public LearningStatistics LearningStatistics { get; set; }
        public NeuralNetwork(List<Layer> tempLayers)
        {
            Structure = new Structure();
            Layers = tempLayers;
            LearningStatistics = new LearningStatistics();
        }
        public NeuralNetwork(Structure tempStructure, CostFunctionEnum costFunctionEnum)
        {
            Structure = tempStructure;
            Layers = new List<Layer>();
            LearningStatistics = new LearningStatistics();
            CreateInputLayer();
            CreateMiddleLayers();
            CreateOutputLayer();
            SetCostFunction(costFunctionEnum);
        }

        [JsonConstructor]
        public NeuralNetwork(Structure structure, List<Layer> layers, ICostFunction costFunction, LearningStatistics learningStatistics)
        {
            Structure = structure;
            Layers = layers;
            CostFunction = costFunction;
            LearningStatistics = learningStatistics;
        }

        #region СозданиеСлоев

        private void CreateInputLayer()
        {
            List<Neuron> inputNeurons = new List<Neuron>();
            for (int i = 0; i < Structure.InputNeuronsCount; i++)
            {
                Neuron neuron = new NeuronInput();
                inputNeurons.Add(neuron);
            }
            if (Structure.Bias == true)
            {
                Neuron bias = new NeuronBias();
                inputNeurons.Add(bias);
            }
            Layer inputLayer = new Layer(inputNeurons);
            Layers.Add(inputLayer);
        }

        private void CreateMiddleLayers()
        {
            for (int i = 0; i < Structure.MiddleLayers.Count; i++)
            {
                List<Neuron> middleNeurons = new List<Neuron>();
                Layer lastLayerNeuronCount = Layers.Last();
                for (int j = 0; j < Structure.MiddleLayers[i]; j++)
                {
                    Neuron neuron = new NeuronNormal(lastLayerNeuronCount.Neurons.Count);
                    middleNeurons.Add(neuron);
                }
                if (Structure.Bias == true)
                {
                    Neuron bias = new NeuronBias();
                    middleNeurons.Add(bias);
                }
                Layer middleLayer = new Layer(middleNeurons);
                Layers.Add(middleLayer);
            }
        }

        private void CreateOutputLayer()
        {
            List<Neuron> outputNeurons = new List<Neuron>();
            Layer lastLayerNeuronCount = Layers.Last();
            for (int i = 0; i < Structure.OutputNeuronsCount; i++)
            {
                Neuron neuron = new NeuronOutput(lastLayerNeuronCount.Neurons.Count);
                outputNeurons.Add(neuron);
            }
            Layer outputLayer = new Layer(outputNeurons);
            Layers.Add(outputLayer);
        }

        public void SetCostFunction(CostFunctionEnum costFunctionEnum)
        {
            switch (costFunctionEnum)
            {
                case CostFunctionEnum.AbsoluteError:
                    CostFunction = null;
                    break;
                case CostFunctionEnum.BinaryLogLoss:
                    CostFunction = new BinaryLogLoss();
                    LearningStatistics.CurrentStatics = LearningStatistics.LogLoss;
                    break;
                case CostFunctionEnum.CategoryLogLoss:
                    CostFunction = new CategoryLogLoss();
                    LearningStatistics.CurrentStatics = LearningStatistics.LogLoss;
                    break;
                case CostFunctionEnum.SquaredError:
                    CostFunction = new SquaredError();
                    LearningStatistics.CurrentStatics = LearningStatistics.Mse;
                    break;
            }
        }

        #endregion

        #region РасчетыОтвета

        public List<(string Name, double Output, double NormalizedOutput)> Predict(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return Layers.Last().GetAnswer();
        }

        public List<double> Predict_ReturnOnlyValues(List<double> inputSignals)
        {
            SendSignalsToInputLayer(inputSignals);
            SendSignalsAfterInputLayer();
            return Layers.Last().GetSignals();
        }

        private void SendSignalsToInputLayer(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; i++)
            {
                List<double> signal = new List<double> { inputSignals[i] };
                Layers.First().Neurons[i].ProcessInformation(signal);
            }
        }

        private void SendSignalsAfterInputLayer()
        {
            for (int i = 1; i < Layers.Count; i++)
            {
                Layer layer = Layers[i];
                List<double> previousLayerSignals = Layers[i - 1].GetSignals();
                foreach (Neuron neuron in layer.Neurons)
                    neuron.ProcessInformation(previousLayerSignals);

                if (layer is LayerSoftMax layerSoftMax)
                    layerSoftMax.ProcessInformation();
            }
        }

        #endregion

        #region Обучение

        public void Learn_Backpropogation(LearningData learningData, double errorLimit, double learningRate = 0.1)
        {
            do
            {
                var currentEpochError = new List<double>();
                for (int j = 0; j < learningData.LearningExamples.Count; j++)
                {
                    LearningExample example = learningData.LearningExamples[j];
                    var currentExampleError = Learn_RecalculateError(example);
                    currentEpochError.Add(currentExampleError);
                    Learn_ChangeWeights(learningRate);
                }
                learningData.Mix();
                LearningStatistics.CurrentStatics.Add(currentEpochError.Average());
            } 
            while (LearningStatistics.CurrentStatics.Last() >= errorLimit);
        }

        public void Learn_Backpropogation(LearningData learningData, int epochTimes, double learningRate = 0.1)
        {
            for (int i = 0; i < epochTimes; i++)
            {
                var currentEpochError = new List<double>();
                for (int j = 0; j < learningData.LearningExamples.Count; j++)
                {
                    LearningExample example = learningData.LearningExamples[j];
                    var currentExampleError = Learn_RecalculateError(example);
                    currentEpochError.Add(currentExampleError);
                    Learn_ChangeWeights(learningRate);
                }
                learningData.Mix();
                LearningStatistics.CurrentStatics.Add(currentEpochError.Average());
            }
        }

        private double Learn_RecalculateError(LearningExample example)
        {
            Predict(example.InputSignals);
            Layers.Last().CalculateError(example.ExpectedOutputs, CostFunction);
                
            for (int i = Layers.Count - 2; i > 0; i--)
            {
                Layer currentLayer = Layers[i];
                Layer previousRightLayer = Layers[i + 1];
                currentLayer.CalculateError(previousRightLayer);
            }

            var actualResult = Predict_ReturnOnlyValues(example.InputSignals)[0];
            var expectedResult = example.ExpectedOutputs[0];
            return CostFunction.Function(expectedResult, actualResult);
        }

        private void Learn_ChangeWeights(double learningRate)
        {
            for (int i = Layers.Count - 1; i > 0; i--)
                for (int j = Layers[i].Neurons.Count - 1; j >= 0; j--)
                    Layers[i].Neurons[j].Learn_ChangeWeights(learningRate);
        }

        #endregion

        #region НормализацияМаштабирование

        public void Normalization(LearningData learningData)
        {
            for (int i = 0; i < Layers.First().Neurons.Count; i++)
            {
                if (Layers.First().Neurons[i].NeuronType == Structure.NeuronType.Bias)
                    continue;

                var column = learningData.LearningExamples.Select(item => item.InputSignals[i]).ToList();
                column.Sort();
                Layers.First().Neurons[i].Min = column.First();
                Layers.First().Neurons[i].Max = column.Last();
                if (learningData.ParamNamesInput != null)
                    Layers.First().Neurons[i].Name = learningData.ParamNamesInput[i];
            } //нормализация входного слоя
        }

        public void NormalizationOutput(LearningData learningData)
        {
            for (int i = 0; i < Layers.Last().Neurons.Count; i++)
            {
                var column = learningData.LearningExamples.Select(item => item.ExpectedOutputs[i]).ToList();
                column.Sort();
                Layers.Last().Neurons[i].Min = column.First();
                Layers.Last().Neurons[i].Max = column.Last();
                if (learningData.ParamNamesOutput != null)
                    Layers.Last().Neurons[i].Name = learningData.ParamNamesOutput[i];
            } //выходного слоя
        }

        #endregion
    }
}
