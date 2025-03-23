using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgramGUI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedForm r = new RedForm();
            r.MdiParent = this;
            r.Show();
        }

        private void blueFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlueForm b = new BlueForm();
            b.MdiParent = this;
            b.Show();
        }

        private void greenFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreenForm g = new GreenForm();
            g.MdiParent = this;
            g.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
