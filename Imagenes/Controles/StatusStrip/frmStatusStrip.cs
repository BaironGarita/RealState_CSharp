using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmStatusStrip : Form
    {
        public frmStatusStrip()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opci�n1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opci�n N 1");
        }

        private void opci�n2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opci�n N 2");
        }

        private void frmStatusStrip_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void frmStatusStrip_Load(object sender, EventArgs e)
        {

        }
    }
}