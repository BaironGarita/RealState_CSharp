using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Controles
{
    public partial class frmPilasColas : Form
    {
        public frmPilasColas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Falta validación de espacios en blanco

            erpMensajeError.Clear();
            // Validación
            if (string.IsNullOrEmpty(this.txtPalidrome.Text) == true)
            {
                erpMensajeError.SetError(txtPalidrome, "Debe Ingresar una expresión");
                this.txtPalidrome.Focus();
                // errorProvider.Clear();
                return;
            }

            // Agregar Cada Caracter en la Pila
            Pila oPila = new Pila();
            // Agregar a la Pila
            oPila.Agregar(txtPalidrome.Text.Trim());
            // Pregunto si es Palindrome
            //this.notifyIcon.Text 
            nfiMensaje.BalloonTipText = oPila.EsPalindrome() == true ? "Es Palíndrome por Pila" : "No es Palíndrome por Pila";
            nfiMensaje.Visible = true;
            nfiMensaje.ShowBalloonTip(5);
            Thread.Sleep(5000);

            // Agregar Cada Caracter en la Pila
            Cola oCola = new Cola();
            // Agregar a la Pila


            oCola.Agregar(txtPalidrome.Text.Trim());
            // Pregunto si es Palindrome
            //this.notifyIcon.Text 
            nfiMensaje.BalloonTipText = oCola.EsPalindrome() == true ? "Es Palíndrome por Cola" : "No es Palíndrome por Cola";
            nfiMensaje.Visible = true;
            nfiMensaje.ShowBalloonTip(5);



        }
    }
}
