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
    public partial class frmNumerosAleatorios : Form
    {

        // Atributo Privado
        private int contador;
        private int valorAleatorioGenerado;

        public frmNumerosAleatorios()
        {
            // no tocar esto lo genera .NET
            InitializeComponent();
          
           contador = 0;
           
           GenerarNumeroAleatorio();

        }

        
        /// <summary>
        /// Genera el Número aleatorio
        /// </summary>
        private void GenerarNumeroAleatorio()
        {
            // Generar número aleatorio entre 1 y 10 
               
            Random numero = new Random();
             
            // Asignarselo al Atributo
            valorAleatorioGenerado = numero.Next(9) + 1;
             
        }

        private void frmNumerosAleatorios_Load(object sender, EventArgs e)
        {
            // tambièn puedo acceder los atributos en tiempo de ejecuciòn
            this.Text = "Números  Aleatorios";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            String mensajeError = "";
            int valorDigito = 0;
            // capturar posibles errores
            try
            {
                // contador de ejecuciones
                contador++;

                //  tomar el valos digitado en la caja de texto  
                // Ojo el valor de lectura es en texto por lo tanto
                // requiere conversión a numerico
                valorDigito = int.Parse(txtNumero.Text);

                // si el valor digitado es igual a 
                if (valorDigito == valorAleatorioGenerado)
                {
                    MessageBox.Show("Acertó, Ejecución # "+contador.ToString(),"Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No acertó, Ejecución # " + contador.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch (Exception error) {
                
                mensajeError =  "Data       :"+error.Data + "\n";
                mensajeError += "Message    :"+error.Message + "\n";
                mensajeError += "Source     :"+error.Source + "\n";
                mensajeError += "StackTrace :"+error.StackTrace + "\n";
                MessageBox.Show(mensajeError,"Error");
            }


        }
    }
}
