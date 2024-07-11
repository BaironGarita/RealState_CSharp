using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmTreeView2 : Form
    {
        public frmTreeView2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTreeView2_Load(object sender, EventArgs e)
        {
            IList<string> lista = new List<string>();
  
            TreeNode raiz;
            try
            {
               
                lista.Add("Oracle");
                lista.Add("MySql");
                lista.Add("Postgress");

                // sincronizar con el imagelist
               this.trvBaseDatos.ImageList = this.imgLstImagenes;
             
                // Agregar el nodo raiz
                raiz = trvBaseDatos.Nodes.Add("DataBase", "DataBase", 0, 0);

                 
                foreach (var item in lista)
                {
                    TreeNode nodo = new TreeNode(item, 0, 0);                    
                    // Agregar nodo al padre
                    trvBaseDatos.Nodes[0].Nodes.Add(nodo);
                }
                //trvBaseDatos.ExpandAll();
                this.Focus();

                /*
                raiz = trvBaseDatos.Nodes.Add("Lenguajes", "Lenguajes");
                TreeNode mynode1 = new TreeNode("C++");
                TreeNode mynode2 = new TreeNode("C#");
                 
                trvBaseDatos.Nodes[1].Nodes.Add(mynode1);
                trvBaseDatos.Nodes[1].Nodes.Add(mynode2);
                */
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Atención");
            }
        }


        private void trvBaseDatos_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
           
            if (e.Action == TreeViewAction.ByMouse)
                MessageBox.Show($"Nodo seleccionado {e.Node.Text}");
        }
         

    }
}
