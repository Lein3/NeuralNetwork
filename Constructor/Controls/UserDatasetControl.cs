using NeuralNetworkNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class UserDatasetControl : UserControl
    {
        private Datasets CurrentDataset { get; set; }
        public UserDatasetControl(Datasets dataset)
        {
            InitializeComponent();
            this.Size = MinimumSize;
            CurrentDataset = dataset;
            label_Name.Text = CurrentDataset.Name;
            label_CreationDate.Text = $"Дата создания: {CurrentDataset.CreationDate.ToShortDateString()}";
        }

        private void button_Replace_Click(object sender, EventArgs e)
        {
            var parent = ParentForm as UserDatasetsForm;
            parent.PreviousForm.selectedDatasetID = CurrentDataset.ID_Table;
            parent.DialogResult = DialogResult.OK;
            parent.Close();
        }
    }
}
