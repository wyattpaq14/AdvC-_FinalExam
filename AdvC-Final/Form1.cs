using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvC_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Technicians' table. You can move, or remove it, as needed.
            this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.techniciansTableAdapter.Search(this.techSupportDataSet.Technicians, ((int)(System.Convert.ChangeType(techIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
