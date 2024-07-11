using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmSplitContainer : Form
    {
        public frmSplitContainer()
        {
            InitializeComponent();
        }

        private void frmSplitContainer_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar el grid con controles 
                this.dgvDatos.AutoGenerateColumns = false;
                this.dgvProcesos.AutoGenerateColumns = false;

                // Extrae la ruta de los directorios especiales de Windows
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                foreach (string item in Directory.GetFiles(path))
                {
                    this.dgvDatos.Rows.Add(new string[] { item });
                }

                //
                // Process[] localAll = Process.GetCurrentProcess();

                // Get all processes running on the local computer.
                Process[] localAll = Process.GetProcesses();

                foreach (Process proceso in localAll)
                {

                    this.dgvProcesos.Rows.Add(new string[] { proceso.ProcessName, proceso.PagedSystemMemorySize64.ToString() });

                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void verProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvProcesos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in this.dgvProcesos.SelectedRows)
                    {
                        MessageBox.Show($"Proceso Seleccionado:  {item.Cells[0].Value}", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
