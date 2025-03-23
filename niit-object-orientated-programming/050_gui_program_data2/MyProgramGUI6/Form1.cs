using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgramGUI6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nIITORADataSet);

        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nIITORADataSet);

        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nIITORADataSet);

        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nIITORADataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nIITORADataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.nIITORADataSet.EMPLOYEES);
            // TODO: This line of code loads data into the 'nIITORADataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.nIITORADataSet.DEPARTMENTS);

        }
    }
}
