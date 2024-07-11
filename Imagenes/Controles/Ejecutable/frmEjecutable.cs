using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmEjecutable : Form
    {
        public frmEjecutable()
        {
            InitializeComponent();
        }

        private void frmEjecutable_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutarCalculadora_Click(object sender, EventArgs e)
        {  
            Process.Start("calc");  
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process P = new System.Diagnostics.Process();
            P.EnableRaisingEvents = false;
            P.StartInfo.FileName = "msedge";
            P.StartInfo.FileName = "iexplore";
            P.StartInfo.Arguments = "http://www.utn.ac.cr";
            P.Start();
            P.WaitForExit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            Process.Start("osk");
        }
    }
}
