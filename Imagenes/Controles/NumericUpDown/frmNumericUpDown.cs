using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmNumericUpDown : Form
    {
        public frmNumericUpDown()
        {
            InitializeComponent();
        }

        private void nUDNumerico_ValueChanged(object sender, EventArgs e)
        {
            this.lstLista.Items.Add(nUDNumerico.Value.ToString());

        }

        private void nUDincrementador_ValueChanged(object sender, EventArgs e)
        {
            nUDNumerico.Increment = nUDincrementador.Value;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}