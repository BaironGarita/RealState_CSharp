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

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción N 1");
        }

        private void opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción N 2");
        }

        private void frmStatusStrip_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void frmStatusStrip_Load(object sender, EventArgs e)
        {

        }
    }
}