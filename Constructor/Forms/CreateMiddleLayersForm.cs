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

        private void DrawSeparator(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 5f);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Point p1 = new Point(100, 10);
            Point p2 = new Point(100, panel_neurons.Height);
            e.Graphics.DrawLine(pen, p1, p2);
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
                    var control = new NeuronControl(neuron, index++);
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

        private void numericUpDown_main_ValueChanged(object sender, EventArgs e)
        {                 
            tabPage_this.Controls.Clear();
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
                numeric.ValueChanged += numericUpDown_Secondary_ValueChanged;

                tabPage_this.Controls.Add(label);
                tabPage_this.Controls.Add(numeric);


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
            foreach (var numeric in tabPage_this.Controls.OfType<NumericUpDown>())
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
        }
    }
}
