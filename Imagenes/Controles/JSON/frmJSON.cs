using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;

namespace Controles
{
    // Serializacion Definicion https://msdn.microsoft.com/es-es/library/ms233843.aspx
    // La serialización es el proceso de convertir un objeto en una secuencia de bytes 
    // para almacenar el objeto o transmitirlo a memoria, una base de datos, o en un archivo. 
    // Su propósito principal es guardar el estado de un objeto para poder crearlo de nuevo cuando se necesita. 
    // El proceso inverso se denomina deserialización. 



    // Nota 
    // Se debe agregar System.Runtime.Serialization.Json

    // Por hacer agregar un property  en la clase Deposito llamado Monto
    // y hacerlo visual en JSON y en el DataGridView

    public partial class frmJSON : Form
    {
        public frmJSON()
        {
            InitializeComponent();
        }

        private void frmJSON_Load(object sender, EventArgs e)
        {

        }




        /// <summary>
        /// Convertir de JSon a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnConvertirJSON_A_List_Click(object sender, EventArgs e)
        {

            string datos = "";
            List<Deposito> listaDepositos = new List<Deposito>();
            try
            {
                // limpiar el dataGridView en caso que tenga algo
                this.dgvJSON.DataSource = null;

                if (string.IsNullOrEmpty(this.rtbJSON.Text))
                {
                    // Este error es capturado en el catch
                    throw new ArgumentException("El valor no puede ir en blanco", nameof(rtbJSON));

                    // MessageBox.Show("No hay datos en el RichText", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  return;
                }
                 
                // leer los datos del richText a la variable
                datos = this.rtbJSON.Text;
                listaDepositos =  JsonConvert.DeserializeObject<List<Deposito>>(datos);
                
                //listaDepositos = JSONGeneric<Deposito>.JSonToList(datos);
                 

                this.dgvJSON.DataSource = listaDepositos;



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

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Convertir de List<object> a string en formato JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnListObject_a_JSON_Click(object sender, EventArgs e)
        {
            string datos = "";
            List<Deposito> listaDepositos = new List<Deposito>();

            try
            {
                // Limpiar el RichText
                this.rtbJSON.Clear();


                // Sacar del DataGridView a una lista
                listaDepositos = (List<Deposito>)this.dgvJSON.DataSource;
                datos = JsonConvert.SerializeObject(listaDepositos);
              
                // Hacer una pausa
                Thread.Sleep(2000);
                // Mostrar los datos
                this.rtbJSON.AppendText(datos);

            }
            catch (Exception error)
            {
               


                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje        {0}", error.Message);
                msg.AppendFormat("Source         {0}", error.Source);
                msg.AppendFormat("InnerException {0}", error.InnerException);
                msg.AppendFormat("StackTrace     {0}", error.StackTrace);

                MessageBox.Show(msg.ToString(), "Error");

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
