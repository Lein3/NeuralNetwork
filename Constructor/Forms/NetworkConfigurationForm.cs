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
        public new MainForm ParentForm { get; set; }
        private List<Layer> Layers { get; set; }
        private bool Bias => checkBox_Bias.Checked;
        private bool DrawOnCenter { get; set; } = false;

        public NetworkConfigurationForm(MainForm mainForm)
        {
            InitializeComponent();
            ParentForm = mainForm;

            if (GlobalTemplate.NeuralNetwork != null)
            {
                LoadNetwork();
                return;
            }

            Layers = new List<Layer>();
            Layers.Add(new Layer(GlobalTemplate.LearningData));
            numericUpDown_NeuronsCountInput.Value = Layers.First().Neurons.Count;
            DisplayNetwork();
            LoadComboboxesWithFuntions();
            tabControl.SelectedIndex = 0;
            textBox_ModelName.Text = "Моя модель";

            if (GlobalTemplate.CurrentWorkMode == GlobalTemplate.WorkMode.freeMode)
            {
                numericUpDown_NeuronsCountInput.Enabled = true;
            }
        }

        private void LoadComboboxesWithFuntions()
        {
            comboBox_SelectActivationFunctionMiddle.DataSource = Enum.GetValues(typeof(Neuron.ActivationFunctionEnum));
            comboBox_SelectActivationFunctionMiddle.SelectedIndex = 5;
            comboBox_SelectActivationFunctionOutput.DataSource = Enum.GetValues(typeof(Neuron.ActivationFunctionEnum));
            comboBox_SelectActivationFunctionOutput.SelectedIndex = 5;
        }

        private void LoadNetwork()
        {
            Layers = GlobalTemplate.NeuralNetwork.Layers;
            textBox_ModelName.Text = GlobalTemplate.ModelName;
            checkBox_Bias.CheckedChanged -= checkBox_Bias_CheckedChanged;
            if (GlobalTemplate.NeuralNetwork.Structure.Bias == true)
            {
                checkBox_Bias.Checked = true;
            }
            checkBox_Bias.CheckedChanged += checkBox_Bias_CheckedChanged;
            numericUpDown_NeuronsCountInput.Value = Layers.First().Neurons.Count - Convert.ToInt32(Bias);
            numericUpDown_NeuronsCountOutput.ValueChanged -= numericUpDown_NeuronsCountOutput_ValueChanged;
            numericUpDown_NeuronsCountOutput.Value = Layers.Last().Neurons.Count;
            numericUpDown_NeuronsCountOutput.ValueChanged += numericUpDown_NeuronsCountOutput_ValueChanged;
            numericUpDown_LayersCountMiddle.ValueChanged -= numericUpDown_LayersCountMiddle_ValueChanged;                 
            PlaceSecondaryNumericsLoaded();
            numericUpDown_LayersCountMiddle.ValueChanged += numericUpDown_LayersCountMiddle_ValueChanged;

            DisplayNetwork();
            LoadComboboxesWithFuntions();
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

            //int x = panel_Neurons.Width / Layers.Count + Layers.Count % 2 * 60;
            int x = 30;
            int y = 30;
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
            ParentForm.button_MiddleLayers.Text = "Скрытые слои ✓";
            ParentForm.button_MiddleLayers.ForeColor = Color.FromArgb(85, 170, 255);

            var values = new List<int>();
            foreach (var control in panel_LayerCountMiddle.Controls.OfType<LayerCountControl>())
            {
                var value = (int)control.numericUpDown_LayerNeuronsCount.Value;
                values.Add(value);
            }

            panel_LayerCountMiddle.Controls.Clear();
            PlaceSecondaryNumerics(values);
            numericUpDown_Secondary_ValueChanged(null, null);
        }

        private void PlaceSecondaryNumerics(List<int> values)
        {
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
        }

        private void PlaceSecondaryNumericsLoaded()
        {
            var values = new List<int>();
            var middleLayers = Layers.Take(Layers.Count - 1).Skip(1);
            numericUpDown_LayersCountMiddle.Value = middleLayers.Count();
            foreach (var layer in middleLayers)
            {
                var value = layer.Neurons.Count;
                values.Add(value);
            }

            for (int i = 0, x = 5, y = 5; i < (int)numericUpDown_LayersCountMiddle.Value; i++, x += 60)
            {
                LayerCountControl layerCountControl = new LayerCountControl(i + 1);              
                try
                {
                    layerCountControl.numericUpDown_LayerNeuronsCount.Value = values[i];
                }
                catch
                {

                }
                layerCountControl.Location = new Point(x, y);
                layerCountControl.numericUpDown_LayerNeuronsCount.ValueChanged += numericUpDown_Secondary_ValueChanged;
                panel_LayerCountMiddle.Controls.Add(layerCountControl);

                if (i % 17 == 0 && i != 0)
                {
                    x = -55;
                    y += 55;
                }
            }
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
                ParentForm.button_OutputLayer.Text = "Выходной слой ✓";
                ParentForm.button_OutputLayer.ForeColor = Color.FromArgb(85, 170, 255);
                ParentForm.button_LayersReady.Enabled = true;
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
                ParentForm.button_InputLayer.Text = "Входной слой ✓";
                ParentForm.button_InputLayer.ForeColor = Color.FromArgb(85, 170, 255);
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

        private void checkBox_Bias_CheckedChanged(object sender, EventArgs e)
        {
            Layers[0] = new Layer(GlobalTemplate.LearningData, Bias);
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
            GlobalTemplate.NeuralNetwork.Structure.Bias = this.Bias;
        }

        private void textBox_ModelName_TextChanged(object sender, EventArgs e)
        {           
            if (!string.IsNullOrWhiteSpace(textBox_ModelName.Text))
            {
                GlobalTemplate.ModelName = textBox_ModelName.Text;
            }
            else
            {
                GlobalTemplate.ModelName = "Моя модель";
            }
        }

        private void textBox_ModelName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e as KeyEventArgs).KeyCode == Keys.Enter || (e as KeyEventArgs).KeyCode == Keys.Escape)
            {
                ActiveControl = null;
            }
        }
    }
}
