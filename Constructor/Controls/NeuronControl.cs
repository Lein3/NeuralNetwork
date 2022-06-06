using System;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class NeuronControl : UserControl
    {
        public Neuron Neuron { get; set; }
        private Rectangle Ellipse { get; set; }
        public NeuronControl(Neuron neuron, double? error = null, int? index = null)
        {
            InitializeComponent();
            this.Neuron = neuron;
            if (error != null)
            {
                var label_error = new Label();
                label_error.BackColor = System.Drawing.Color.Transparent;
                label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label_error.ForeColor = System.Drawing.Color.Black;
                label_error.Location = new System.Drawing.Point(23, 25);
                label_error.Name = "label_error";
                label_error.Size = new System.Drawing.Size(29, 22);
                label_error.TabIndex = 2;
                label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label_error.Text = Math.Round((double)error, 3).ToString();
                Controls.Add(label_error);
                label_error.BringToFront();
            }
            this.Index.Text = index.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2f);
            if (this.Neuron.NeuronType == Structure.NeuronType.Input) pen = new Pen(Color.Blue, 2f);
            if (this.Neuron.NeuronType == Structure.NeuronType.Output) pen = new Pen(Color.Green, 2f);
            Ellipse = new Rectangle(5, 5, 60, 60);
            e.Graphics.DrawEllipse(pen, Ellipse);
        }

        public void Fill()
        {
            var bruh = new SolidBrush(Color.Red);
            pictureBox.CreateGraphics().FillEllipse(bruh, Ellipse);
        }
    }
}
