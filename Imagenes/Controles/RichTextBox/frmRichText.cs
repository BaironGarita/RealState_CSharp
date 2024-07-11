using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmRichText : Form
    {
        public frmRichText()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txttexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttexto_KeyPress(object sender, KeyPressEventArgs e)
        {    
            // si se digitó ENTER
            
            if (e.KeyChar == (char)Keys.Enter)
                this.rtbTexto.AppendText( txttexto.Text);

           

        }

        private void nUDSpin_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(nUDSpin.Value) <= 1)
                this.rtbTexto.ZoomFactor = 1;
            else
                // ZoomFactor tamaño de la letra
                this.rtbTexto.ZoomFactor = Convert.ToInt16(nUDSpin.Value);
        }

         


       

       
    }
}