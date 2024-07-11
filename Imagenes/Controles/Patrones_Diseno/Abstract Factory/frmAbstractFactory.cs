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
    /// <summary>
    /// Proporciona una interfaz para crear familias o dependencias en los objetos sin 
    /// especificar las clases concretas
    /// </summary>
    public partial class frmAbstractFactory : Form
    {
        public frmAbstractFactory()
        {
            InitializeComponent();
        }


        private void btnEjecutar_Click(object sender, EventArgs e)
        { 
            StringBuilder str = new StringBuilder();
            if (chkAfrica.Checked == true)
            {
                // Crea un objeto de tiene dos métodos que a 
                // su vez permiten crear y devolver  objetos 
                // Carniboro o Herbivoro. La clase AfricaFactory
                // es una herencia de una clase Abstracta de ContinentFactory 
                ContinentFactory africa = new AfricaFactory();
                // Crea un objeto Tipo AnimalWorld que el constructor recibe 
                // ContinentFactory. En ese constructor se crean los objetos
                // tipo Carniboro y Herbívoro
                AnimalWorld mundo1 = new AnimalWorld(africa);
                str.Append("En AFRICA :"+mundo1.EjecutarCadenaAlimenticia() + "\n");
            }

            if (ChkAmerica.Checked == true)
            {
                // Crea y  ejecuta al Mundo Animal de America
                ContinentFactory america = new AmericaFactory();
                AnimalWorld mundo2 = new AnimalWorld(america);
                str.Append("En AMERICA :" + mundo2.EjecutarCadenaAlimenticia() + "\n");
            }

            // Si no se escogió ninguna
            if (str.Length == 0)
                return;

            MessageBox.Show(str.ToString(), "Cadena Alimenticia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
