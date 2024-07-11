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
    public partial class frmUserControl : Form
    {
        public frmUserControl()
        {
            InitializeComponent();
        }

        private void frmUserControl_Load(object sender, EventArgs e)
        {
             
        }
        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void toolStripBtnEncriptar_Click(object sender, EventArgs e)
        {
            UserControl _uscEncriptar = new uscEncriptar(this);

            _uscEncriptar.Parent = this;
            _uscEncriptar.Location = new Point(0, 0);
            // ajustarse al contenedor
            _uscEncriptar.Dock = DockStyle.Fill;
            _uscEncriptar.Show();
            // esconder barra principal
            tspEncriptar.Hide();
             
        }

        private void toolStripBtnComprimir_Click(object sender, EventArgs e)
        {

            UserControl _uscComprimir = new uscComprimir(this);

            _uscComprimir.Parent = this;
            _uscComprimir.Location = new Point(0, 0);
            // ajustarse al contenedor
            _uscComprimir.Dock = DockStyle.Fill;
            _uscComprimir.Show();
            // esconder barra principal
            tspEncriptar.Hide();


        }
    }
}
