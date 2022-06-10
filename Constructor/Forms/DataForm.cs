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
using Microsoft.Data.ConnectionUI;

namespace Constructor
{
    public partial class DataForm : Form
    {
        private Point ActivePanelLocation = new Point(270, 150);
        public DataForm()
        {
            InitializeComponent();   
            //TODO: сделать рабочей кнопку мои наборы данных
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromFile.Visible = true;
            panel_FromFile.Location = ActivePanelLocation;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDatabase.Visible = true;
            panel_FromDatabase.Location = ActivePanelLocation;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDataset.Visible = true;
            panel_FromDataset.Location = ActivePanelLocation;
        }

        private void SetAllPanelsInvisible()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
                panel.Visible = false;
        }

        private void button_MyModels_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            textBox_FilePath.Text = openFileDialog.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataConnectionDialog d = new DataConnectionDialog();
            DataSource.AddStandardDataSources(d);
            DataConnectionDialog.Show(d);
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder(d.ConnectionString);
            label_DatabaseName.Text = sqlConnectionString.InitialCatalog;
        }
    }
}
