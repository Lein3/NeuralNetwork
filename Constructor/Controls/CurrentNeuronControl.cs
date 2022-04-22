using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class CurrentNeuronControl : UserControl
    {
        public Neuron CurrentNeuron { get; set; }
        private NeuronFlag neuronFlag;
        public CurrentNeuronControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void pictureBox_CurrentNeuron_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 5f);
            var ellipse = new Rectangle(90, 40, 150, 150);
            e.Graphics.DrawEllipse(pen, ellipse);
            Point p1 = new Point(240, 115);
            Point p2 = new Point(305, 115);
            e.Graphics.DrawLine(pen, p1, p2);
        }

        public void UpdateInfo(Neuron neuron)
        {
            this.CurrentNeuron = neuron;
            label_Name.Text = CurrentNeuron.Name;
            label_Max.Text = CurrentNeuron.Max.ToString();
            label_Min.Text = CurrentNeuron.Min.ToString();
            label_Sum.Text = CurrentNeuron.Sum == 0 ? string.Empty : CurrentNeuron.Sum.ToString();
            label_Output.Text = CurrentNeuron.Output == 0 ? string.Empty : "S = " + CurrentNeuron.Sum.ToString();
            DrawRelationLines();
        }

        private void DrawRelationLines()
        {
            if (CurrentNeuron.NeuronType == Structure.NeuronType.Input)
            {
                var pen = new Pen(Color.Black, 5f);
                Point p1 = new Point(30, 115);
                Point p2 = new Point(90, 115);
                pictureBox_CurrentNeuron.CreateGraphics().DrawLine(pen, p1, p2);
            }

        }

        private void LabelClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            var location = label.Location;
            var numeric = new NumericUpDown();
            numeric.Location = location;
            numeric.Left -= 20;
            numeric.Maximum = int.MaxValue;
            numeric.Minimum = int.MinValue;
            numeric.Size = new Size(60, 20);
            numeric.DecimalPlaces = 2;
            numeric.Value = Convert.ToDecimal(label.Text);
            numeric.ValueChanged += ValueChanged;

            if (label.Name.Contains("Max")) neuronFlag = NeuronFlag.max;
            if (label.Name.Contains("Min")) neuronFlag = NeuronFlag.min;
            label.Visible = false;
            this.Controls.Add(numeric);
            numeric.BringToFront();
        }

        enum NeuronFlag
        {
            max,
            min,
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            var numeric = sender as NumericUpDown;
            this.Controls.Remove(numeric);

            switch (neuronFlag)
            {
                case NeuronFlag.max:
                    CurrentNeuron.Max = Convert.ToDouble(numeric.Value);
                    label_Max.Text = numeric.Value.ToString().Replace(",", "");
                    label_Max.Visible = true;
                    break;
                case NeuronFlag.min:
                    CurrentNeuron.Min = Convert.ToDouble(numeric.Value);
                    label_Min.Text = numeric.Value.ToString().Replace(",", "");
                    label_Min.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void label_Name_DoubleClick(object sender, EventArgs e)
        {
            var label = sender as Label;
            var location = label.Location;
            var textbox = new TextBox();
            textbox.Text = label.Text;
            textbox.Location = location;
            textbox.Left += 150;
            textbox.Top += 20;
            textbox.Size = new Size(80, 20);
            textbox.TextChanged += (sender2, e2) => 
            { 
                label_Name.Text = textbox.Text;
                CurrentNeuron.Name = textbox.Text;
            };
            textbox.KeyDown += (sender3, e3) => 
            {
                if ((e3 as KeyEventArgs).KeyCode == Keys.Enter)
                    this.Controls.Remove(textbox);
            };
            this.Controls.Add(textbox);
            textbox.BringToFront();
            //я понимаю что говнокод но я спешу
        }
    }
}
