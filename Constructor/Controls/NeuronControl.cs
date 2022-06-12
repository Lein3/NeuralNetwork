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
            this.Size = new Size(75, 90);
            //для удобства в работе в конструкторе там элементы большие

            if (error != null)
            {
                label_Error.Text = Math.Round((double)error, 3).ToString();
            }
            label_Index.Text = index.ToString();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(85, 170, 255), 2f);            
            if (Neuron.NeuronType == Structure.NeuronType.Bias)
            {
                pen = new Pen(Color.FromArgb(56, 138, 52), 2f);
            }
            Ellipse = new Rectangle(5, 20, 60, 60);
            e.Graphics.DrawEllipse(pen, Ellipse);
        }

        public void Fill()
        {
            var bruh = new SolidBrush(Color.FromArgb(120, 120, 120));          
            pictureBox.CreateGraphics().FillEllipse(bruh, Ellipse);
            label_Error.BackColor = Color.FromArgb(120, 120, 120);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Fill();
            (ParentForm as NetworkConfigurationForm).currentNeuronControl.UpdateInfo(Neuron);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
            label_Error.BackColor = Color.FromArgb(51, 51, 51);
        }
    }
}
