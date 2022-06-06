using System;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class CurrentNeuronControl : UserControl
    {
        public Neuron CurrentNeuron { get; set; }
        private CreateInputLayerForm parent { get; set; }
        private NeuronFlag neuronFlag { get; set; }
        public CurrentNeuronControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void pictureBox_CurrentNeuron_Paint(object sender, PaintEventArgs e)
        {
            parent = this.ParentForm as CreateInputLayerForm;
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
            switch (neuron.NeuronType)
            {
                case Structure.NeuronType.Input:
                    label_Name.Text = CurrentNeuron.Name;
                    label_Max.Text = CurrentNeuron.Max.ToString();
                    label_Min.Text = CurrentNeuron.Min.ToString();
                    label_Max.Visible = true;
                    label_Min.Visible = true;
                    label_outMax.Visible = false;
                    label_outMin.Visible = false;
                    label_Sum.Text = CurrentNeuron.Sum == 0 ? string.Empty : CurrentNeuron.Sum.ToString();
                    label_Output.Text = CurrentNeuron.Output == 0 ? string.Empty : "S = " + CurrentNeuron.Sum.ToString();
                    break;
                case Structure.NeuronType.Normal:
                    label_Name.Text = "Скрытый";
                    label_Max.Text = CurrentNeuron.Max.ToString();
                    label_Min.Text = CurrentNeuron.Min.ToString();
                    label_Max.Visible = false;
                    label_Min.Visible = false;
                    label_outMax.Visible = false;
                    label_outMin.Visible = false;
                    label_Sum.Text = CurrentNeuron.Sum == 0 ? string.Empty : CurrentNeuron.Sum.ToString();
                    label_Output.Text = CurrentNeuron.Output == 0 ? string.Empty : "S = " + CurrentNeuron.Sum.ToString();
                    break;
                case Structure.NeuronType.Output:
                    label_Name.Text = "Выходной";
                    label_Max.Text = CurrentNeuron.Max.ToString();
                    label_Min.Text = CurrentNeuron.Min.ToString();
                    label_Max.Visible = false;
                    label_Min.Visible = false;
                    label_outMax.Visible = true;
                    label_outMin.Visible = true;
                    label_outMax.Text = "Да";
                    label_outMin.Text = "Нет";
                    label_Sum.Text = CurrentNeuron.Sum == 0 ? string.Empty : CurrentNeuron.Sum.ToString();
                    label_Output.Text = CurrentNeuron.Output == 0 ? string.Empty : "S = " + CurrentNeuron.Sum.ToString();
                    break;
            }              
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
            if (!CheckNormalization())
                return;

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

        private bool CheckNormalization()
        {
            var tabcontrol = parent.tabControl;
            switch (tabcontrol.SelectedIndex)
            {
                case 0:
                    if (parent.radioButton_yes1.Checked == true) return true;
                    break;
                case 1:
                    if (parent.radioButton_yes2.Checked == true) return true;
                    break;
                default:
                    break;
            }
            return false;
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
                    label_Max.Text = numeric.Value.ToString();
                    label_Max.Visible = true;
                    break;
                case NeuronFlag.min:
                    CurrentNeuron.Min = Convert.ToDouble(numeric.Value);
                    label_Min.Text = numeric.Value.ToString();
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
                if ((e3 as KeyEventArgs).KeyCode == Keys.Enter || (e3 as KeyEventArgs).KeyCode == Keys.Escape)
                    this.Controls.Remove(textbox);
            };
            this.Controls.Add(textbox);
            textbox.BringToFront();
            //я понимаю что говнокод но я спешу
        }
    }
}
