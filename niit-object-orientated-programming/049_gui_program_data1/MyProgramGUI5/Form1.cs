﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgramGUI5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mYPERSONSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mYPERSONSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.MYPERSONS' table. You can move, or remove it, as needed.
            this.mYPERSONSTableAdapter.Fill(this.dataSet1.MYPERSONS);

        }
    }
}
