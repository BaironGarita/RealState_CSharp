using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class uscEncriptar : UserControl
    {
        frmUserControl _frmUserControl;

        public uscEncriptar()
        {
            InitializeComponent();
        }


        public uscEncriptar(frmUserControl pfrmUserControl)
        {
            InitializeComponent();
            _frmUserControl = pfrmUserControl;
        }
        


        private void uscEncriptar_Load(object sender, EventArgs e)
        {
            this.Width = Parent.Width;
            this.Height = Parent.Height;
        }

        private void btnComprimir_Click(object sender, EventArgs e)
        {
            try
            {
                IEncripta encriptador = null;


                if (rdbTripleDES.Checked)
                {
                    encriptador = new TripleDES();
                }

                if (this.rdbAES.Checked)
                {
                    encriptador = new AES();
                }


                if (this.rdbRSA.Checked)
                {
                    encriptador = new RSA();
                    ((ILlaves)encriptador).CrearLlaves();
                }

                this.txtRespuesta.Text = encriptador.Encriptar(this.txtPalabra.Text);


            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescomprimir_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                IEncripta encriptador = null;


                if (rdbTripleDES.Checked)
                {
                    encriptador = new TripleDES();
                }

                if (this.rdbAES.Checked)
                {
                    encriptador = new AES();
                }

                if (this.rdbRSA.Checked)
                {
                    encriptador = new RSA();

                }

                respuesta = encriptador.Desencriptar(this.txtRespuesta.Text);

                MessageBox.Show("La palabra descompresa es -> " + respuesta + "\n y el algoritmo de descompresi/n  fue " + encriptador.GetType().Name, "Atenci/n", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmUserControl.tspEncriptar.Show();           
            Parent.Refresh();
            
        }

        private void toolStripBtnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                IEncripta encriptador = null;
               

                if (rdbTripleDES.Checked)
                {
                    encriptador = new TripleDES();
                }

                if (this.rdbAES.Checked)
                {
                    encriptador = new AES();
                }


                if (this.rdbRSA.Checked)
                {
                    encriptador = new RSA();
                    ((ILlaves)encriptador).CrearLlaves();
                }

                this.txtRespuesta.Text = encriptador.Encriptar(this.txtPalabra.Text);


            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnDescomprimir_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                IEncripta encriptador = null;


                if (rdbTripleDES.Checked)
                {
                    encriptador = new TripleDES();
                }

                if (this.rdbAES.Checked)
                {
                    encriptador = new AES();
                }

                if (this.rdbRSA.Checked)
                {
                    encriptador = new RSA();

                }

                respuesta = encriptador.Desencriptar(this.txtRespuesta.Text);

                MessageBox.Show("La palabra descompresa es -> " + respuesta + "\n y el algoritmo de desencripción fue " + encriptador.GetType().Name, "Atenci/n", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception er)
            {

                MessageBox.Show("Error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
