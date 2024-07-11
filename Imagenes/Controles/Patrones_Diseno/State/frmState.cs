using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property 
        /// </summary>
        private LuzTrafico oLuzTrafico = new LuzTrafico();

        private void frmState_Load(object sender, EventArgs e)
        {
            //Estado Inicial
            oLuzTrafico.Estado = new LuzVerde();
        }

        private void btnNuevoEstado_Click(object sender, EventArgs e)
        {
            try
            {
               // LuzTrafico oLuzTrafico = new LuzTrafico();
               // oLuzTrafico.Estado = new  LuzVerde();

                oLuzTrafico.Cambiar();
                TipoEstado estado = oLuzTrafico.GetEstado();

                // Colocar todos sin color
                this.pnlAmarillo.BackColor = Color.Transparent;
                this.pnlRojo.BackColor = Color.Transparent;
                this.pnlVerde.BackColor = Color.Transparent;


                switch (estado)
                {
                    case TipoEstado.Rojo:
                        this.pnlRojo.BackColor = Color.Red;
                        break;
                    case TipoEstado.Verde:
                        this.pnlVerde.BackColor = Color.Green;
                        break;
                    case TipoEstado.Amarillo:
                        this.pnlAmarillo.BackColor = Color.Yellow;
                        break;
                   
                }


            }
            catch (Exception er)
            {
                MessageBox.Show($"Error {er.Message}","Atención");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
