using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections; // se requiere para utilizar ArrayList

namespace Controles
{
    public partial class frmTreeView : Form
    {
        private  ArrayList oArregloNodos;

        public frmTreeView()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            // Crear objeto Arreglo e iniciarlo
            ArrayList oArreglo = new ArrayList();
            int indice=0;

            // Agregar al Arreglo
            oArreglo.Add("Lenguajes");
            oArreglo.Add("Bases de Datos");
            
            
            // Recorrer el arreglo
            foreach (String item in oArreglo) {                
               
                this.trvArbol.Nodes.Add(item);
                this.trvArbol.Nodes[indice].Tag = "Key" + indice.ToString();
                indice++;
            }

            // Agregar Hijos al nodo 0
              trvArbol.Nodes[0].Nodes.Add("C#");
              trvArbol.Nodes[0].ImageIndex = 0;
              trvArbol.Nodes[0].Nodes[0].Tag = "Hijo1";
              trvArbol.Nodes[0].Nodes[0].ImageIndex = 0;  

              trvArbol.Nodes[0].Nodes.Add("C");
              trvArbol.Nodes[0].Nodes[1].Tag = "Hijo2";

              trvArbol.Nodes[0].Nodes.Add("C++");
              trvArbol.Nodes[0].Nodes[2].Tag = "Hijo3";

              trvArbol.Nodes[0].Nodes.Add("J#");
              trvArbol.Nodes[0].Nodes[3].Tag = "Hijo4";
            
              trvArbol.Nodes[0].Nodes.Add("Lisp");
              trvArbol.Nodes[0].Nodes[4].Tag = "Hijo5";
           
              trvArbol.Nodes[0].Nodes.Add("JDeveloper");
              trvArbol.Nodes[0].Nodes[5].Tag = "Hijo6";
            
              trvArbol.Nodes[0].Nodes.Add("Java");
              trvArbol.Nodes[0].Nodes[6].Tag = "Hijo7";


              // Agregar Hijos al nodo 1
              trvArbol.Nodes[1].Nodes.Add("Oracle");
              trvArbol.Nodes[1].ImageIndex = 1;
              trvArbol.Nodes[1].Nodes[0].Tag = "Hijo8";
              trvArbol.Nodes[1].Nodes[0].ImageIndex = 1;

              trvArbol.Nodes[1].Nodes.Add("Sybase");
              trvArbol.Nodes[1].Nodes[1].Tag = "Hijo9";
              trvArbol.Nodes[1].Nodes[1].ImageIndex = 1;
             
              trvArbol.Nodes[1].Nodes.Add("MySql");
              trvArbol.Nodes[1].Nodes[2].Tag = "Hijo10";
              trvArbol.Nodes[1].Nodes[2].ImageIndex = 1;
            
              trvArbol.Nodes[1].Nodes.Add("Postgres");
              trvArbol.Nodes[1].Nodes[3].Tag = "Hijo11";
              trvArbol.Nodes[1].Nodes[3].ImageIndex = 1;

              // asignar imagenes  a los nodos
            //  this.trvArbol.Nodes[0].ImageIndex = 0;
            //  this.trvArbol.Nodes[1].ImageIndex = 1;
              


          }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void trvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

            MessageBox.Show("Texto del Nodo: "+ e.Node.Text +  "\n   Llave del Nodo :" + trvArbol.SelectedNode.Tag);
            
        }

        private void btnBorrarNodo_Click(object sender, EventArgs e)
        {
            if (trvArbol.SelectedNode != null )
                this.trvArbol.Nodes.Remove(trvArbol.SelectedNode);
                

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             string mensaje = "";
             oArregloNodos = new ArrayList();

            // Coleccion de nodos
            TreeNodeCollection nodes = this.trvArbol.Nodes;
            
            // recorrer los nodos base
            foreach (TreeNode miNodo in nodes)
            {
               
                oArregloNodos.Add("Id :"+miNodo.Tag+" Nodo:"+ (String)miNodo.Text );

                RecorridoRecursivo(miNodo);
            }

            foreach (String cadena in oArregloNodos)
            { 
                mensaje += cadena.ToString() + "\n";
            }
            MessageBox.Show(mensaje);
        }

        private void RecorridoRecursivo(TreeNode treeNode)
        {
            this.oArregloNodos.Add("Id :"+treeNode.Tag+" Nodo :"+(String)treeNode.Text);
            
            foreach (TreeNode tn in treeNode.Nodes)
            {
                RecorridoRecursivo(tn);
            }
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
           
        }

    }
}