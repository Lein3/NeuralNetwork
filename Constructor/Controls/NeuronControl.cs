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


            foreach (Control element in this.Controls)
            {
                element.BackColor = Color.Transparent;
                element.MouseEnter += onMouseEnter;
                element.MouseLeave += onMouseLeave;
            }

            if (error != null)
            {
                var label_error = new Label();
                label_error.BackColor = Color.Transparent;
                label_error.Font = new Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label_error.ForeColor = Color.Black;
                label_error.Location = new Point(23, 25);
                label_error.Name = "label_error";
                label_error.Size = new Size(29, 22);
                label_error.TabIndex = 2;
                label_error.TextAlign = ContentAlignment.MiddleCenter;
                label_error.Text = Math.Round((double)error, 3).ToString();
                Controls.Add(label_error);
                label_error.BringToFront();
            }
            this.Index.Text = index.ToString();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(85, 170, 255), 2f);
            Ellipse = new Rectangle(5, 20, 60, 60);
            e.Graphics.DrawEllipse(pen, Ellipse);
        }

        public void Fill()
        {
            var bruh = new SolidBrush(Color.Red);
            pictureBox.CreateGraphics().FillEllipse(bruh, Ellipse);
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            Fill();
            var parent = this.ParentForm as NetworkConfigurationForm;
            parent.currentNeuronControl.UpdateInfo(Neuron);
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }
    }
}
