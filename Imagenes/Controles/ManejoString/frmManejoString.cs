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
    public partial class frmManejoString : Form
    {
        public frmManejoString()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            String resultado = "";
            // Invocar mètodo
            resultado = metodoString();
            MessageBox.Show(resultado);
        }

        // Devuelve una String
        private String metodoString()
        {
            String retornar = "";
            int contador = 0;
            String resultado = "\n";
 
            String lista = "Universidad Tècnica Nacional";

            retornar  = "lista.Length                     :" + lista.Length.ToString() + "\n";
            retornar += "lista.ToUpper()                  :" + lista.ToUpper().ToString() + "\n";
            retornar += "lista.ToLower()                  :" + lista.ToLower().ToString() + "\n";
            retornar += "lista.Replace('e','2')           :" + lista.Replace('e', '2').ToString() + "\n";
            retornar += "lista.Substring(0,11)            :" + lista.Substring(0, 11).ToString() + "\n";
            retornar += "lista.Contains('Z')              :" + lista.Contains('Z').ToString() + "\n";
            retornar += "lista.CompareTo(lista)           :" + lista.CompareTo(lista).ToString() + "\n";
            retornar += "lista.Equals(lista,StringComparison.CurrentCultureIgnoreCase)    :" + lista.Equals(lista, StringComparison.CurrentCultureIgnoreCase).ToString() + "\n";
            retornar += "lista.IndexOf('T')               :" + lista.IndexOf('T').ToString() + "\n";
            retornar += "lista[5]                        :" + lista[5]  + "\n";
 

            // separa las palabras
            String[] vectorTipoString = lista.Split(' ');
          
            foreach (string palabra in vectorTipoString)
            {
               contador++;
               resultado += "No "+contador.ToString() + " Palabra --> "+palabra  + "\n";
               
            }

            resultado += "Total de Palabras " + contador.ToString() + "\n";

            retornar += "lista.Split(' ')               :" + resultado;

            return retornar;



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder("");
            cadena.Clear();
            string sede = "Central";
            cadena.Append("Universidad ");
            cadena.Append("Tècnica ");
            cadena.AppendFormat("{0} Sede {1}", "Nacional",sede);
   

            // importante utilizar el ToString para extraer el contenido de la String
            MessageBox.Show(cadena.ToString(),"StringBuilder");
            

        }
    }
}
