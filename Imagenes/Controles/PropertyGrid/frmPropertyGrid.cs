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
    public partial class frmPropertyGrid : Form
    {
        private static int numeroSerial = 0;


        public frmPropertyGrid()
        {
            InitializeComponent();

             
        }

        private void frmPropertyGrid_Load(object sender, EventArgs e)
        {
            Celular oCelular = new Celular();
            oCelular.Serial = (++numeroSerial).ToString();
            this.ppgCelulares.SelectedObject = oCelular;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Sacar el celular del Objeto Property Grid
            Celular oCelularTemporal = (Celular)this.ppgCelulares.SelectedObject;

          
            // Agregar el Objeto en la lista
            this.lstCelulares.Items.Add(oCelularTemporal);
            
            // Crear nuevo objeto y asignarlo a PropertyGrid
            Celular oCelular = new Celular();
            // Se incrementa el ++ y se convierte a String 
            oCelular.Serial = (++numeroSerial).ToString();
            // Asignar objeto tipo Celular en PropertyGrid
            this.ppgCelulares.SelectedObject = oCelular;

        }

        private void lstCelulares_MouseClick(object sender, MouseEventArgs e)
        {
            String msg = "";

            if (lstCelulares.Items.Count == 0 || lstCelulares.SelectedItem == null)
                return;

            // Extraer el objeto Seleccionado
            Celular oCelular = (Celular)this.lstCelulares.SelectedItem;

            msg = "Serial :" + oCelular.Serial + "\nMarca :" + oCelular.Marca + "\nBandas :" + oCelular.bandas;

            MessageBox.Show(msg, "Objeto Seleccionado",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

       
    }
}
