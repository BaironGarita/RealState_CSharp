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
    public partial class uscComprimir : UserControl
    {
        private frmUserControl _frmUserControl;

        public uscComprimir()
        {
            InitializeComponent();
        }

        public uscComprimir(frmUserControl pfrmUserControl)
        {
            InitializeComponent();

            _frmUserControl = pfrmUserControl;
        }


        private void toolStripBtnComprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtRespuesta.Text=  Compresor.Comprimir(this.txtDatos.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void uscComprimir_Load(object sender, EventArgs e)
        {

        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmUserControl.tspEncriptar.Show();
            Parent.Refresh();
        }

        private void toolStripBtnDescomprimir_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            try
            {
                respuesta = Compresor.Descomprimir(this.txtRespuesta.Text);

                MessageBox.Show("Datos descompresos "+respuesta);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
