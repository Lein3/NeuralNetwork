using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class NetworkConfigurationForm : Form
    {
        private List<Layer> Layers { get; set; }
        private bool Bias { get; set; } = false;
        private bool DrawOnCenter { get; set; } = false;

        public NetworkConfigurationForm()
        {
            InitializeComponent();
            Layers = new List<Layer>();
            Layers.Add(new Layer(GlobalTemplate.LearningData));

            DisplayNetwork();
            numericUpDown_NeuronsCountInput.Value = Layers.First().Neurons.Count;
            comboBox_SelectActivationFunctionMiddle.DataSource = Enum.GetValues(typeof(Neuron.ActivationFunctionEnum));
            comboBox_SelectActivationFunctionMiddle.SelectedIndex = 5;
            comboBox_SelectActivationFunctionOutput.DataSource = Enum.GetValues(typeof(Neuron.ActivationFunctionEnum));
            comboBox_SelectActivationFunctionOutput.SelectedIndex = 5;          
            tabControl.SelectedIndex = 0;

            if (GlobalTemplate.CurrentWorkMode == GlobalTemplate.WorkMode.freeMode)
            {
                numericUpDown_NeuronsCountInput.Enabled = true;
            }
        }

        private void DisplayNetwork()
        {           
            int max = 0;
            foreach (var layer in Layers)
            {
                if (layer.Neurons.Count > max)
                {
                    max = layer.Neurons.Count;
                }
            }                

            int x = panel_Neurons.Width / Layers.Count;
            int y;
            int index = 1;
            panel_Neurons.Controls.Clear();

            foreach (var layer in Layers)
            {
                if (DrawOnCenter == true)
                {
                    y = 30 + (max - layer.Neurons.Count) * 65; //ну тут чисто на интеллекте
                }
                else
                {
                    y = 30;
                }
                foreach (var neuron in layer.Neurons)
                {
                    
                    var control = new NeuronControl(neuron, null, index++);
                    var point = new Point(x, y);
                    control.Location = point;
                    panel_Neurons.Controls.Add(control);
                    y += 130;
                }
                x += 115;
            }
        }

        private void DrawSeparator(object sender, PaintEventArgs e)
        {           
            var pen = new Pen(Color.White, 5f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };

            var firstNeuron = panel_Neurons.Controls.OfType<NeuronControl>().First();
            var postionX = firstNeuron.Location.X + firstNeuron.Width + 20;
            var point1 = new Point(postionX, 0);
            var point2 = new Point(postionX, panel_Neurons.Height);
            e.Graphics.DrawLine(pen, point1, point2);

            if (Layers?.LastOrDefault()?.Neurons?.FirstOrDefault()?.NeuronType == Structure.NeuronType.Output)
            {
                var lastNeuron = panel_Neurons.Controls.OfType<NeuronControl>().Last();
                var postionX2 = lastNeuron.Location.X - 20;
                var point3 = new Point(postionX2, 0);
                var point4 = new Point(postionX2, panel_Neurons.Height);
                e.Graphics.DrawLine(pen, point3, point4);
            }
        }

        #region Скрытые слои
        private void numericUpDown_LayersCountMiddle_ValueChanged(object sender, EventArgs e)
        {
            var parent = this.ParentForm as MainForm;
            parent.button_MiddleLayers.Text = "Скрытые слои ✓";
            parent.button_MiddleLayers.ForeColor = Color.FromArgb(85, 170, 255);

            var values = new List<int>();
            foreach (var control in panel_LayerCountMiddle.Controls.OfType<LayerCountControl>())
            {
                var value = (int)control.numericUpDown_LayerNeuronsCount.Value;
                values.Add(value);
            }

            panel_LayerCountMiddle.Controls.Clear();
            for (int i = 0, x = 5, y = 5; i < (int)numericUpDown_LayersCountMiddle.Value; i++, x += 60)
            {
                LayerCountControl layerCountControl = new LayerCountControl(i + 1);
                layerCountControl.numericUpDown_LayerNeuronsCount.ValueChanged += numericUpDown_Secondary_ValueChanged;
                try
                {
                    layerCountControl.numericUpDown_LayerNeuronsCount.Value = values[i];
                }
                catch
                {
                    
                }
                layerCountControl.Location = new Point(x, y);
                panel_LayerCountMiddle.Controls.Add(layerCountControl);

                if (i % 17 == 0 && i != 0)
                {
                    x = -55;
                    y += 55;
                }
            }
            numericUpDown_Secondary_ValueChanged(null, null);
        }

        private void numericUpDown_Secondary_ValueChanged(object sender, EventArgs e)
        {
            Layers.RemoveRange(1, Layers.Count - 1); // это оставляет только 1 слой
            var values = new List<int>();
            foreach (var control in panel_LayerCountMiddle.Controls.OfType<LayerCountControl>())
            {
                var value = (int)control.numericUpDown_LayerNeuronsCount.Value;
                values.Add(value);
            }        
            foreach (var value in values)
            {
                var layer = new Layer(Structure.NeuronType.Normal, Layers.Last().Neurons.Count, value, Bias);
                Layers.Add(layer);
            }
            DisplayNetwork();
        }

        private void comboBox_SelectActivationFunctionMiddle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var activationFunction = (Neuron.ActivationFunctionEnum)comboBox_SelectActivationFunctionMiddle.SelectedValue;
            if (activationFunction == Neuron.ActivationFunctionEnum.Softmax && GlobalTemplate.CurrentWorkMode != GlobalTemplate.WorkMode.freeMode)
            {
                MessageBox.Show("В текущем режиме нельзя установить Softmax для скрытых слоев");
                comboBox_SelectActivationFunctionMiddle.SelectedIndex = 5;
                return;
            }
            setActivationFunctionToMiddleLayer(activationFunction);
        }

        private void setActivationFunctionToMiddleLayer(Neuron.ActivationFunctionEnum activationFunction)
        {
            foreach (var layer in Layers.Skip(1))
            {
                foreach(var neuron in layer.Neurons)
                {
                    if (neuron.NeuronType == Structure.NeuronType.Bias)
                        continue;

                    neuron.SetActivationFunction(activationFunction);
                }
            }
        }
        #endregion

        #region Выходной слой
        private void numericUpDown_NeuronsCountOutput_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_NeuronsCountOutput.Value == 0)
            {                
                return;
            }
            else
            {
                numericUpDown_NeuronsCountOutput.Minimum = 1;
                var parent = this.ParentForm as MainForm;
                parent.button_OutputLayer.Text = "Выходной слой ✓";
                parent.button_OutputLayer.ForeColor = Color.FromArgb(85, 170, 255);
                parent.button_LayersReady.Enabled = true;
            }
            if (Layers.Last().Neurons.FirstOrDefault()?.NeuronType == Structure.NeuronType.Output)
            {
                Layers.Remove(Layers.Last());
            }

            Layer layer = null;
            if (GlobalTemplate.CurrentScenario != GlobalTemplate.Scenario.multiclassClassification)
            {
                layer = new Layer(Structure.NeuronType.Output, Layers.Last().Neurons.Count, (int)numericUpDown_NeuronsCountOutput.Value, Bias);
            }
            else
            {
                layer = new LayerSoftMax(Layers.Last().Neurons.Count, GlobalTemplate.LearningData.ParamNamesOutput.Count);
                comboBox_SelectActivationFunctionOutput.SelectedIndex = 6;
                comboBox_SelectActivationFunctionOutput.Enabled = false;
                numericUpDown_NeuronsCountOutput.Enabled = false;
            }
            Layers.Add(layer);
            DisplayNetwork();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedIndex == 1)
            {
                var parent = this.ParentForm as MainForm;
                parent.button_InputLayer.Text = "Входной слой ✓";
                parent.button_InputLayer.ForeColor = Color.FromArgb(85, 170, 255);
            }
            if (tabControl.SelectedIndex == 2)
            {
                numericUpDown_NeuronsCountOutput.Value = GlobalTemplate.LearningData.ParamNamesOutput.Count;
                numericUpDown_NeuronsCountOutput_ValueChanged(null, null);
            }
        }

        private void comboBox_SelectActivationFunctionOutput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var activationFunction = (Neuron.ActivationFunctionEnum)comboBox_SelectActivationFunctionOutput.SelectedValue;
            setActivationFunctionToOutputLayer(activationFunction);
        }

        private void setActivationFunctionToOutputLayer(Neuron.ActivationFunctionEnum activationFunction)
        {
            foreach (var neuron in Layers.Last().Neurons)
            {
                neuron.SetActivationFunction(activationFunction);
            }
        }
        #endregion

        #region Другие настройки
        private void checkBox_Bias_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Bias.Checked == true)
            {
                Bias = true;
                Layers.First().Neurons.Add(new Neuron_Bias());
            }
            else
            {
                Bias = false;
                Layers.First().Neurons.Remove(Layers.First().Neurons.Last());
            }
            numericUpDown_LayersCountMiddle_ValueChanged(null, null);
            numericUpDown_NeuronsCountOutput_ValueChanged(null, null);
        }

        private void checkBox_DrawOnCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DrawOnCenter.Checked == true)
            {
                DrawOnCenter = true;
            }
            else
            {
                DrawOnCenter = false;
            }
            DisplayNetwork();
        }

        public void SaveNetwork()
        {
            GlobalTemplate.NeuralNetwork = new NeuralNetwork(Layers);
        }
        #endregion
    }
}
