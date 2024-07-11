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
    public partial class frmSingleton : Form
    {

        
        public frmSingleton()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
         
        private void btnEjemplo_Click(object sender, EventArgs e)
        {
           

            // Se crea el singleton de la forma LARGA
            this.lstDetalle.Items.Add(Computer.Instance().ObtenerInformacion());

            // Se crea el singleton de una forma + simplificada
            Computer SingletonComputadora2 = Computer.Instance();
            this.lstDetalle.Items.Add(SingletonComputadora2.ObtenerInformacion());

            Computer SingletonComputadora3 = Computer.Instance();
            this.lstDetalle.Items.Add(SingletonComputadora3.ObtenerInformacion());

            // Descomente las dos líneas, compile e interprete el error que muestra
            //Computer Computadora = new Computer();
            //Computadora.ObtenerInformacion();

            if (Computer.Instance() == SingletonComputadora2 && SingletonComputadora2 == SingletonComputadora3)
            {
                this.lstDetalle.Items.Add("Los 3 Objetos son la misma Instancia !");
            } 
              
        }

        private void frmSingleton_Load(object sender, EventArgs e)
        {
            
           
            
        }

        
    }
}
