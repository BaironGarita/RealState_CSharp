using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            // Coloca el foco a la página N 2
            this.tcControl.SelectedIndex = 1 ;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            this.tcControl.SelectedIndex = 2;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.tcControl.SelectedIndex =0;
        }

        private void frmTabControl_Load(object sender, EventArgs e)
        {

        }
    }
}