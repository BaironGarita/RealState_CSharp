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
    public partial class frmParametros : Form
    {
        public frmParametros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Observe esta declaración de variables
                decimal? kilos = null;
                decimal? libras = null;
                decimal temporal = 0M;
                bool error = false;
                string descripcionError = "";


                //Limpiar Objetos
                erpError.Clear();
                this.txtLibras.Text = "";

                if (string.IsNullOrEmpty(this.txtKilos.Text))
                {
                    erpError.SetError(txtKilos, "El valor de los Kilos es requerido! ");
                    txtKilos.Focus();
                    return;
                }


                // Validar conversión.Ojo no se puede enviar la variable Kilos
                // por que es de tipo "decimal?"
                if (Decimal.TryParse(this.txtKilos.Text, out temporal) == false)
                {
                    // Componente para mostrar  Errores
                    erpError.SetError(txtKilos, "El valor de los Kilos es incorrecto ");
                    txtKilos.Focus();
                    return;
                }
                else
                {
                    kilos = temporal;
                }


                // se invoca al Método estático, observe la palabra que se antepone
                // antes de las variables out y ref
                ConvertirKilosLibras(kilos, out libras, out error, ref descripcionError);


                if (error == true)
                {
                    erpError.SetError(txtKilos, "Error al indicar Kilos");
                    MessageBox.Show(descripcionError, "Error");
                }
                else
                {
                    this.txtLibras.Text = string.Format("{0:D}", libras.ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Descripción del Error  " + error.Message, "Error");
            }
        }


        /// <summary>
        /// Convierte de Kilos a Libras
        /// </summary>
        /// <param name="pKilos"></param>
        /// <param name="refLibras"></param>
        /// <param name="pError"></param>
        /// <param name="pDescripcionError"></param>
        public static void ConvertirKilosLibras(decimal? pKilos, 
                                               out decimal? refLibras,
                                               out bool pError, 
                                               ref String pDescripcionError)
        {

          

            // viene null el parámetro kilos 
            if (pKilos.Value <= 0)
            {
                pError = true;
                pDescripcionError = "Los kilos deben ser mayor o igual a 1";
                refLibras = 0;
                return;
            }

            refLibras = pKilos * (Decimal)2.2;
            pError = false;

        }

        private void frmParametros_Load(object sender, EventArgs e)
        {

        }
    }
}
