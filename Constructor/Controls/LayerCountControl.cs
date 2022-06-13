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
    public partial class LayerCountControl : UserControl
    {
        public LayerCountControl(int layerIndex)
        {
            InitializeComponent();
            label_LayerName.Text += layerIndex.ToString();
        }
    }
}
