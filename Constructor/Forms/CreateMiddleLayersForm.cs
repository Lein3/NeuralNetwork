using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class CreateMiddleLayersForm : CreateInputLayerForm
    {
        List<Layer> Layers { get; set; }
        public CreateMiddleLayersForm()
        {
            InitializeComponent();
            Layers = new List<Layer>(NetworkTemplate.Layers);
            UpdateAllLayers();
        }

        private void UpdateAllLayers()
        {
            panel_neurons.Controls.Clear();
            DrawAllLayers(); 
        }

        private void DrawAllLayers()
        {
            int x = 10;
            int y = 30;
            int index = 1;
            foreach (var layer in Layers)
            {
                foreach (var neuron in layer.Neurons)
                {
                    var control = new NeuronControl(neuron, null, index++);
                    var point = new Point(x, y);
                    control.Location = point;
                    control.pictureBox.MouseClick += onMouseEnter; //тут все верно не трогай
                    control.pictureBox.MouseLeave += onMouseLeave;
                    panel_neurons.Controls.Add(control);
                    y += 100;
                }
                x += 100;
                y = 30;
            }
            panel_neurons.Invalidate();
        }

        private void DrawSeparator(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 5f);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            var firstNeuron = panel_neurons.Controls.OfType<NeuronControl>().First();
            var postionX = firstNeuron.Location.X + firstNeuron.Width + 20;
            var postionY = firstNeuron.Location.Y;
            var point1 = new Point(postionX, postionY);
            var point2 = new Point(postionX, panel_neurons.Height);
            e.Graphics.DrawLine(pen, point1, point2);

            if (Layers.Last().Neurons.Last().NeuronType == Structure.NeuronType.Output)
            {
                var lastNeuron = panel_neurons.Controls.OfType<NeuronControl>().Last();
                var postionX2 = lastNeuron.Location.X - 15;
                var postionY2 = lastNeuron.Location.Y;
                var point3 = new Point(postionX2, postionY);
                var point4 = new Point(postionX2, panel_neurons.Height);
                e.Graphics.DrawLine(pen, point3, point4);
            }
        }

        private void numericUpDown_main_ValueChanged(object sender, EventArgs e)
        {                 
            tabPage_thisNormal.Controls.Clear();
            for (int i = 0, x = 10, y = 10; i < (int)numericUpDown_main.Value; i++, x += 70)
            {
                var label = new Label();
                label.Location = new Point(x, y);
                label.AutoSize = true;
                label.Text = "Слой " + (i + 1).ToString();

                var numeric = new NumericUpDown();
                numeric.Location = new Point(x, y + 20);
                numeric.Size = new Size(50, 20);
                numeric.Value = 1;
                numeric.Minimum = 1;
                numeric.ValueChanged += numericUpDown_Secondary_ValueChanged;

                tabPage_thisNormal.Controls.Add(label);
                tabPage_thisNormal.Controls.Add(numeric);


                if (i % 16 == 0 && i != 0)
                {
                    x = -60;
                    y += 50;
                }
            }
            numericUpDown_Secondary_ValueChanged(null, null);
        }

        private void numericUpDown_Secondary_ValueChanged(object sender, EventArgs e)
        {
            var values = new List<int>();
            foreach (var numeric in tabPage_thisNormal.Controls.OfType<NumericUpDown>())
            {
                var value = (int)numeric.Value;
                values.Add(value);
            }

            Layers.RemoveRange(1, Layers.Count - 1);

            foreach (var value in values)
            {
                var neurons = new List<Neuron>();
                for (int i = 0; i < value; i++)
                {
                    Neuron_Normal neuron = new Neuron_Normal(Layers.Last().Neurons.Count);
                    neurons.Add(neuron);
                }
                var layer = new Layer(neurons);
                Layers.Add(layer);
            }

            UpdateAllLayers();

            var parent = this.ParentForm as AuthorizationForm;
            //parent.button3.Enabled = true;
        }

        private void tabPage_thisOut_Enter(object sender, EventArgs e)
        {
            var parent = this.ParentForm as AuthorizationForm;
            
            //if (parent.button3.Enabled == true)
            //{
            //    label_neuronsMain.Visible = false;
            //    numericUpDown_main.Visible = false;
            //    label_neuronOut.Visible = true;
            //    numericUpDown_out.Visible = true;
            //}
        }

        private void tabPage_thisNormal_Enter(object sender, EventArgs e)
        {
            label_neuronsMain.Visible = true;
            numericUpDown_main.Visible = true;
        }

        private void numericUpDown_out_ValueChanged(object sender, EventArgs e)
        {
            if (Layers.Last().Neurons.Last().NeuronType == Structure.NeuronType.Output)
                Layers.Remove(Layers.Last());

            var neurons = new List<Neuron>();
            for (int i = 0; i < (int)numericUpDown_out.Value; i++)
            {
                Neuron_Output neuron = new Neuron_Output(Layers.Last().Neurons.Count);
                neurons.Add(neuron);
            }
            var layer = new Layer(neurons);
            Layers.Add(layer);
            NetworkTemplate.Layers = Layers;
            UpdateAllLayers();

            var parent = this.ParentForm as AuthorizationForm;
            //parent.button4.Enabled = true;
        }
    }
}
