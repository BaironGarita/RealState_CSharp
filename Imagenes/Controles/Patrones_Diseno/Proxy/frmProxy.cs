using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmProxy : Form
    {
        public frmProxy()
        {
            InitializeComponent();
        }

        private void frmProxy_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                
                ComunicaProxy oComunicaProxy = new ComunicaProxy();

                oComunicaProxy.Habla(this.rtbDatos.Text, this.trbVelocidad.Value, this.trbVolumen.Value);

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message,"Atenci/n"); ;
            }
        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
