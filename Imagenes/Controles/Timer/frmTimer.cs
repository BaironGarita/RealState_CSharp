using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int numero = Int16.Parse(lblEtiqueta.Text) + 1;


            this.lblEtiqueta.Text = numero.ToString();

        }

        private void frmTimer_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // iniciar el timer
            this.tmrTiempo.Start();
            Application.DoEvents();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            // iniciar el timer
            this.tmrTiempo.Stop();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}