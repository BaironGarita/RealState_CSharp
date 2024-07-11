using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Controles
{

    public partial class frmBoton : Form
    {

        public frmBoton()
        {
            InitializeComponent();
        }


        private void btnBoton1_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje
            MessageBox.Show("Mundo", "Hola");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // cierra la ventana actual
            this.Close();
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {

            DialogResult resultado;
            resultado = MessageBox.Show("Viva la Sele con Suarez", "Encuesta",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


            switch (resultado)
            {

                case DialogResult.Cancel:
                    MessageBox.Show("Ud no respondio la encuesta", "Mensaje");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Ud es positivo", "Mensaje");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Ud es negativo", "Mensaje");
                    break;
                default:
                    break;
            }


        }



        private void btnBoton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otro estilo de botón !");
        }


        private void btnOtroBoton_Click(object sender, EventArgs e)
        {


            DialogResult resultado;
            try
            {
                resultado = MessageBox.Show("Vamos a clasificar al mundial de Qatar ?", "Encuesta",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                    MessageBox.Show("Vamos al mundial!!!! ", "Sele");
                else
                    MessageBox.Show("Nos quedamos en casa !", "Sele");

                // Forzar error
                // StringBuilder s = new StringBuilder("123");
                // s.ToString().Substring(1, 2000000);

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

        private void frmBoton_Load(object sender, EventArgs e)
        {

        }



    }
}