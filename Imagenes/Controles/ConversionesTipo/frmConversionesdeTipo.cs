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
    public partial class frmConversionesdeTipo : Form
    {
        public frmConversionesdeTipo()
        {
            InitializeComponent();
        }

        private void frmConversionesdeTipo_Load(object sender, EventArgs e)
        {

        }

        private void btnCualquierTipoAString_Click(object sender, EventArgs e)
        {
            StringBuilder cadena = new StringBuilder();

          

            // convertir a String 
            int      variable_int = 1;
            decimal  variable_dec = 1m;
            double variable_double = 1.0;
            Int16    variable_int16 =1;
            Int32    variable_int32 =1;
            Int64    variable_int64 =1;
            short variable_short = 1;
            float variable_float = 1f;
            long variable_long = 1;


            cadena.AppendFormat("int     {0}:", variable_int.ToString()) ;
            cadena.AppendFormat("decimal {0}:", variable_dec.ToString());
            cadena.AppendFormat("double  {0}:", variable_double.ToString());
            cadena.AppendFormat("Int16   {0}:", variable_int16.ToString());
            cadena.AppendFormat("Int32   {0}:", variable_int32.ToString());
            cadena.AppendFormat("Int64   {0}:", variable_int64.ToString());
            cadena.AppendFormat("short   {0}:", variable_short.ToString());
            cadena.AppendFormat("float   {0}:", variable_float.ToString());
            cadena.AppendFormat("long    {0}:", variable_long.ToString());
            MessageBox.Show($"Convertir a String un valor numèrico  \n{cadena.ToString()}");

           




        
        }

        private void btnConversiondetipo_Click(object sender, EventArgs e)
        {

            double resultado_double = 0.0;
            float resultado_float = 0f;
            Int64 resultado_Int64 = 0;
            
            string valor1 = "1";
            string valor2 = "2";

            resultado_double = Double.Parse(valor1) + Double.Parse(valor2);
            MessageBox.Show( "Double.Parse(valor1) + Double.Parse(valor2): "+resultado_double.ToString(),"double");

            // Casting 

            resultado_float = (float)Double.Parse(valor1) + (float)Double.Parse(valor2);
            MessageBox.Show("(float) Double.Parse(valor1) + (float) Double.Parse(valor2): " + resultado_float.ToString(), "float");

            resultado_Int64 = Int64.Parse(valor1) + Int64.Parse(valor2);
            MessageBox.Show("(Int64) Double.Parse(valor1) + (float) Double.Parse(valor2): " + resultado_Int64.ToString(), "double");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
