using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmCheckbox : Form
    {
        public frmCheckbox()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
           
            try
            {
                 
                if (chkOpcion1.Checked)
                    mensaje = "CheckBox No 1 :Tratado de Comercio con Europa  \n";

                if (chkOpcion2.Checked == true)
                    mensaje += "CheckBox No 2 :Tratado de Comercio con USA     \n";

                if (chkMercosur.Checked == true)
                    mensaje += "CheckBox No 3 :Mercosur     \n";
                
                if (string.IsNullOrEmpty(mensaje) == true)
                {
                    MessageBox.Show("Ud no marco ninguno!", "Atencion");
                }
                else
                {
                    MessageBox.Show(mensaje, "Atención");
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("InnerException {0}\n", error.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);

                MessageBox.Show(msg.ToString(), "Error");
            }

             

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

       

        private void frmCheckbox_Load(object sender, EventArgs e)
        {

        }







    }
}