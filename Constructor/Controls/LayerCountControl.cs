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
