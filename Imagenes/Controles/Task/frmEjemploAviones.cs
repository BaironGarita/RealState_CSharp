using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;



namespace Controles
{
    public partial class frmEjemploAviones : Form
    {
         

        public frmEjemploAviones()
        {
            InitializeComponent();
        }

          

        private void frmEjemploAviones_Load(object sender, EventArgs e)
        {
          
        }

        private async void btnCompetenciaAsincronica_Click(object sender, EventArgs e)
        {
            try
            { 

                long result = 1;
                for (int counter = 1; counter <= 13; counter++)
                {
                    result = await CompetenciaAsincrona();
                    lblMensaje.Text = "Interacion " + counter.ToString();
                }
                 

                MessageBox.Show("Terminó la competencia !");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error "+er.Message);
            }
        }

         

        private async Task<int> CompetenciaAsincrona()
        {
            int x = 0;
            
            await Task.Delay(1000);
            
            x = (int)pb1.Location.X + 20;               
            pb1.Location = new Point(x, pb1.Location.Y);

            x = (int)pb2.Location.X + 40;
            pb2.Location = new Point(x, pb2.Location.Y);

            x = (int)pb3.Location.X + 60;
            pb3.Location = new Point(x, pb3.Location.Y); 

            return 0;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
