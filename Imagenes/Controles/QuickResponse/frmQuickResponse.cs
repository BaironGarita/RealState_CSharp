using System;
using System.Diagnostics;
using System.Windows.Forms;

// Referencia  16-6-2013
// http://null-byte.wonderhowto.com/how-to/write-your-very-own-qr-code-generator-c-part-1-0132667/


namespace Controles
{
    public partial class frmQuickResponse : Form
    {
        public frmQuickResponse()
        {
            InitializeComponent();
        }

        private void toolStripBtnN_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnQuickResponse_Click(object sender, EventArgs e)
        {
            try
            {
                int nivel = 0; // depende del máximo de caracteres permitidos
                nivel = 53;   // Existen los niveles  17,32,53,78,108,134,154,
                // 192,230,271,321,367,425,458,520,586,644,718
                // 792, 858

                QuickResponse qr = new QuickResponse();
                pbImagenQuickResponse.Image = qr.QuickResponseGenerador(this.txtDato.Text, nivel);
            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atención");
            }
        }

        private void toolStripBtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbImagenQuickResponse.Image == null)
                {
                    return;
                }

                SaveFileDialog dialogo = new SaveFileDialog();
                dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialogo.Title = "Nombre de la Imagen";
                dialogo.SupportMultiDottedExtensions = false;
                dialogo.FileName = "qr.png";
                dialogo.Filter = ".png | *.*";
                dialogo.ShowDialog(this);



                this.pbImagenQuickResponse.Image.Save(dialogo.FileName + ".png");


            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atención");
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                Process.Start("osk");
        }

        private void frmQuickResponse_Load(object sender, EventArgs e)
        {

        }
    }
}
