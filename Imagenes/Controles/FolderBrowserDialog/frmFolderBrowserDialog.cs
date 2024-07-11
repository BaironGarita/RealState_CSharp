using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmFolderBrowserDialog : Form
    {
        public frmFolderBrowserDialog()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            this.fbdDialog.ShowDialog(this);
            this.lblMensaje.Text = fbdDialog.SelectedPath.ToString();
        }

       
    }
}
