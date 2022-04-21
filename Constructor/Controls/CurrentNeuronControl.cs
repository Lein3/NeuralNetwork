using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class CurrentNeuronControl : UserControl
    {
        public CurrentNeuronControl()
        {
            InitializeComponent();
        }

        private void pictureBox_CurrentNeuron_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 5f);
            var ellipse = new Rectangle(((PictureBox)sender).Width / 4, ((PictureBox)sender).Height / 7, 150, 150);
            e.Graphics.DrawEllipse(pen, ellipse);
            Point p1 = new Point(235, 100);
            Point p2 = new Point(305, 100);
            e.Graphics.DrawLine(pen, p1, p2);
        }
    }
}
