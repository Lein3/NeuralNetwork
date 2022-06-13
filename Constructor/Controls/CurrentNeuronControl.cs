using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class CurrentNeuronControl : UserControl
    {
        public Neuron CurrentNeuron { get; set; }

        public CurrentNeuronControl()
        {
            InitializeComponent();
        }

        private void pictureBox_CurrentNeuron_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.FromArgb(85, 170, 255), 5f);
            var ellipse = new Rectangle(100, 40, 140, 140);
            e.Graphics.DrawEllipse(pen, ellipse);
            Point p1 = new Point(40, 115);
            Point p2 = new Point(100, 115);
            e.Graphics.DrawLine(pen, p1, p2);
            Point p3 = new Point(240, 115);
            Point p4 = new Point(300, 115);
            e.Graphics.DrawLine(pen, p3, p4);
        }

        private void DrawRelationLines(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.FromArgb(85, 170, 255), 5f);
            Point p1 = new Point(60, 60);
            Point p2 = new Point(100, 115);
            e.Graphics.DrawLine(pen, p1, p2);

            Point p3 = new Point(45, 95);
            Point p4 = new Point(100, 115);
            e.Graphics.DrawLine(pen, p3, p4);

            Point p5 = new Point(45, 145);
            Point p6 = new Point(100, 115);
            e.Graphics.DrawLine(pen, p5, p6);

            Point p7 = new Point(55, 170);
            Point p8 = new Point(100, 115);
            e.Graphics.DrawLine(pen, p7, p8);
        } //не очень хорошая идея рисовать связи

        public void UpdateInfo(Neuron neuron)
        {
            this.CurrentNeuron = neuron;
            switch (neuron.NeuronType)
            {
                case Structure.NeuronType.Bias:
                    DisplayInfo("Нейрон смещения", false);
                    break;
                case Structure.NeuronType.Input:
                    DisplayInfo(CurrentNeuron.Name, true);
                    break;
                case Structure.NeuronType.Normal:
                    DisplayInfo("Скрытый нейрон", false);
                    break;
                case Structure.NeuronType.Output:
                    DisplayInfo("Выходной нейрон", false);
                    break;
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach(var weight in neuron.Weights)
            {
                stringBuilder.AppendLine(weight.ToString());
            }
            toolTip.SetToolTip(pictureBox_WeightsShow, stringBuilder.ToString());
        }

        private void DisplayInfo(string neuronName, bool labelMinMaxVisible)
        {
            label_Name.Text = neuronName;
            label_Max.Text = CurrentNeuron.Max.ToString();
            label_Min.Text = CurrentNeuron.Min.ToString();
            label_Max.Visible = labelMinMaxVisible;
            label_Min.Visible = labelMinMaxVisible;
            label_Sum.Text = CurrentNeuron.Sum == 0 ? string.Empty : CurrentNeuron.Sum.ToString();
            label_Output.Text = CurrentNeuron.Output == 0 ? string.Empty : "S = " + CurrentNeuron.Sum.ToString();
            label_ActivationFunction.Text = "Функция активации: " + CurrentNeuron.ActivationFunction?.ToString().Substring(23); //neuralnetworknamespace. то то то
        }

        private void label_Max_DoubleClick(object sender, EventArgs e)
        {
            label_Max.Visible = false;
            numericUpDown_Max.Visible = true;
            numericUpDown_Max.Value = (decimal)CurrentNeuron.Max;
        }

        private void numericUpDown_Max_ValueChanged(object sender, EventArgs e)
        {
            CurrentNeuron.Max = Convert.ToDouble(numericUpDown_Max.Value);
            label_Max.Text = (sender as NumericUpDown).Value.ToString();
            label_Max.Visible = true;
            numericUpDown_Max.Visible = false;
        }

        private void label_Min_DoubleClick(object sender, EventArgs e)
        {
            label_Min.Visible = false;
            numericUpDown_Min.Visible = true;
            numericUpDown_Min.Value = (decimal)CurrentNeuron.Max;
        }

        private void numericUpDown_Min_ValueChanged(object sender, EventArgs e)
        {
            CurrentNeuron.Min = Convert.ToDouble(numericUpDown_Min.Value);
            label_Min.Text = numericUpDown_Min.Value.ToString();
            label_Min.Visible = true;
            numericUpDown_Min.Visible = false;
        }

        private void label_Name_DoubleClick(object sender, EventArgs e)
        {
            textBox_ChangeNeuronName.Visible = true;
            label_Name.TextAlign = ContentAlignment.MiddleRight;
            label_Name.Left -= 50;
        }

        private void textBox_ChangeNeuronName_TextChanged(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(textBox_ChangeNeuronName.Text))
            {
                label_Name.Text = textBox_ChangeNeuronName.Text;
                CurrentNeuron.Name = textBox_ChangeNeuronName.Text;
            }
        }

        private void textBox_ChangeNeuronName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e as KeyEventArgs).KeyCode == Keys.Enter || (e as KeyEventArgs).KeyCode == Keys.Escape)
            {
                textBox_ChangeNeuronName.Visible = false;
                label_Name.TextAlign = ContentAlignment.MiddleCenter;
                label_Name.Left += 50;
                textBox_ChangeNeuronName.Text = null;
            }             
        }

        private void label_ActivationFunction_DoubleClick(object sender, EventArgs e)
        {
            if (GlobalTemplate.CurrentWorkMode == GlobalTemplate.WorkMode.freeMode)
            {
                label_ActivationFunction.Text = "Функция активации: ";
                comboBox_SelectActivationFunction.Visible = true;
                comboBox_SelectActivationFunction.DataSource = Enum.GetValues(typeof(Neuron.ActivationFunctionEnum));
            }
        }
    }
}
