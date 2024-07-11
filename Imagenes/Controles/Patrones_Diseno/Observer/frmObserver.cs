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
    public partial class frmObserver : Form
    {

        UsuarioUTN _UsuarioUTN;
        UsuarioCaraLibro _Usuario1;
        UsuarioCaraLibro _Usuario2;


        public frmObserver()
        {
            InitializeComponent();
        }

        private void frmObserver_Load(object sender, EventArgs e)
        {
            
           
            // Se crea el usuario Subject
            _UsuarioUTN = new UsuarioUTN()
            {
                Nombre = "Universidad T/cnica Nacional",
                Apellido = ""
            };

            //Se crean los usuarios Observables
            _Usuario1 = new UsuarioCaraLibro(_UsuarioUTN, "Vilma", "Picapiedra", this.lsvUsuario1);
            _Usuario2 = new UsuarioCaraLibro(_UsuarioUTN, "Pablo", "Marmol", this.lsvUsuario2);

            //Se registran los usuarios observables
            _UsuarioUTN.RegisterObserver(_Usuario1);
            _UsuarioUTN.RegisterObserver(_Usuario2);
            this.txtMensaje.Focus();

        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();

            try
            {
                // Si se digit/ Enter
                if (e.KeyCode == Keys.Enter)
                {

                    if (string.IsNullOrEmpty(this.txtMensaje.Text))
                    {
                        error.SetError(this.txtMensaje, "Debe ingregar el mensaje");
                        return;
                    }

                    error.Clear();

                    _UsuarioUTN.Mensaje = this.txtMensaje.Text;

                    // Notificar a los objetos
                    _UsuarioUTN.NotifyObserver();

                    // Agregar al Listview
                    ListViewItem item = new ListViewItem(this.txtMensaje.Text);
                    item.ImageIndex = 0;
                    this.lsvEnviarMensajeUTN.Items.Add(item);


                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Error");
            }
        }

        private void chkVilma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVilma.Checked)
            {
                _UsuarioUTN.RegisterObserver(_Usuario1);
            }
            else
            {
                _UsuarioUTN.RemoveObserver(_Usuario1);
            }
        }

        private void chkPablo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPablo.Checked)
            {
                _UsuarioUTN.RegisterObserver(_Usuario2);
            }
            else
            {
                _UsuarioUTN.RemoveObserver(_Usuario2);
            }
        }
    }
}
