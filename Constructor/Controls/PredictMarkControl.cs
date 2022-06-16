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
    public partial class PredictMarkControl : UserControl
    {
        public PredictMarkControl()
        {
            InitializeComponent();
        }

        private void comboBox_PredictMark_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            parent.learningData.SwapToParamOutput(comboBox_PredictMark.SelectedIndex);
            parent.dataGridView.DataSource = null;
            parent.dataGridView.DataSource = parent.learningData.ConvertToDotNetDataSet().Tables[0];
            parent.UpdateComboBoxPredictMark();
        }
    }
}
