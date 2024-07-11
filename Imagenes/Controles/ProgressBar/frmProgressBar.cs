using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace Controles
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
             
            for (int contador = 0; contador < 100; contador++) {

                // Delay 
                Thread.Sleep(50);
                pgbBarra.Value = contador; 
                pgbBarra.Update();
            }
            
            
            for (int contador = 100; contador > 0; contador--)
            {
                // Delay 
                System.Threading.Thread.Sleep(50);
                pgbBarra2.Value = contador;
                pgbBarra2.Update();
            }

            pgbBarra2.Value = 0 ;

        }

        private void frmProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}