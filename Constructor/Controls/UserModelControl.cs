using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Constructor
{
    public partial class UserModelControl : UserControl
    {
        public NeuralNetworks NeuralNetworks { get; set; }
        public UserModelControl(NeuralNetworks neuralNetworks)
        {
            InitializeComponent();
            NeuralNetworks = neuralNetworks;
            label_Name.Text += NeuralNetworks.Name;
            label_InputNeurons.Text += NeuralNetworks.InputNeuronsCount.ToString();
            label_MiddleNeurons.Text += NeuralNetworks.MiddleLayers.ToString();
            label_OutputNeurons.Text += NeuralNetworks.OutputNeuronsCount.ToString();
            label_Bias.Text += NeuralNetworks.Bias.ToString();
            label_ActivationFunction.Text += NeuralNetworks.ActivationFunctions.Name;
            label_CostFunction.Text += NeuralNetworks.CostFunctions?.Name;

            var listControls = new List<Control>()
            {
                label_ActivationFunction,
                label_Bias,
                label_CostFunction,
                label_InputNeurons,
                label_MiddleNeurons,
                label_Name,
                label_OutputNeurons
            };
            listControls.ForEach(item =>
            {
                item.MouseEnter += UserModelControl_MouseEnter;
            });
            listControls.ToList().ForEach(item => item.DoubleClick += CustomDoubleClick);
        }

        public void CustomDoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(new EventArgs());
        }

        private void UserModelControl_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void UserModelControl_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
