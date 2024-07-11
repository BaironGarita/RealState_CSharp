using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 
namespace Controles
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            // Colocar los detalles de la vista
            lvwListview.View = View.Details;

           
            // Agregar una columna de 30 espacios con alienación izquierda.
            lvwListview.Columns.Add("Lenguaje", 100, HorizontalAlignment.Left);
            lvwListview.Columns.Add("Mercado", 100, HorizontalAlignment.Left);
            lvwListview.Columns.Add("Escala", 100, HorizontalAlignment.Left);
            
            // agregar items
            this.lvwListview.Items.Add("C#");
            this.lvwListview.Items.Add("C++");
            this.lvwListview.Items.Add("Java");
            this.lvwListview.Items.Add("Lisp");
            this.lvwListview.Items.Add("Haskel");

           
            
            // Subitems
            lvwListview.Items[0].SubItems.Add("Alto");
            lvwListview.Items[1].SubItems.Add("Medio");
            lvwListview.Items[2].SubItems.Add("Alto");
            lvwListview.Items[3].SubItems.Add("Bajo");
            lvwListview.Items[4].SubItems.Add("Bajo");

            // Subitems
            lvwListview.Items[0].SubItems.Add("95%");
            lvwListview.Items[1].SubItems.Add("40%");
            lvwListview.Items[2].SubItems.Add("90%");
            lvwListview.Items[3].SubItems.Add("20%");
            lvwListview.Items[4].SubItems.Add("5%");


            // indicar las imagenes a utilizar
            lvwListview.Items[0].ImageIndex = 0;
            lvwListview.Items[1].ImageIndex = 0;
            lvwListview.Items[2].ImageIndex = 0;
            lvwListview.Items[3].ImageIndex = 0;
            lvwListview.Items[4].ImageIndex = 0;

            
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            lvwListview.CheckBoxes = true;
        }

        private void chkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            lvwListview.View = View.Details;

            // agregar checks al listview 
            if (this.lvwListview.CheckBoxes == true)
                this.lvwListview.CheckBoxes = false;
            else
                this.lvwListview.CheckBoxes = true;
        }

        private void rdbDetails_CheckedChanged(object sender, EventArgs e)
        {
            lvwListview.View = View.Details;
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            // indicar las imagenes a utilizar
            lvwListview.Items[0].ImageIndex = 0;
            lvwListview.Items[1].ImageIndex = 0;
            lvwListview.Items[2].ImageIndex = 0;
            lvwListview.Items[3].ImageIndex = 0;
            lvwListview.Items[4].ImageIndex = 0; 

            lvwListview.View = View.LargeIcon;
        }

        private void rdSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            // indicar las imagenes a utilizar
            lvwListview.Items[0].ImageIndex = 0;
            lvwListview.Items[1].ImageIndex = 0;
            lvwListview.Items[2].ImageIndex = 0;
            lvwListview.Items[3].ImageIndex = 0;
            lvwListview.Items[4].ImageIndex = 0; 

            lvwListview.View = View.SmallIcon;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdList_CheckedChanged(object sender, EventArgs e)
        {
            // indicar las imagenes a utilizar
            lvwListview.Items[0].ImageIndex = 0;
            lvwListview.Items[1].ImageIndex = 0;
            lvwListview.Items[2].ImageIndex = 0;
            lvwListview.Items[3].ImageIndex = 0;
            lvwListview.Items[4].ImageIndex = 0;

            lvwListview.View = View.List;
        }

        private void rdTile_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // indicar las imagenes a utilizar
                lvwListview.Items[0].ImageIndex = 0;
                lvwListview.Items[1].ImageIndex = 0;
                lvwListview.Items[2].ImageIndex = 0;
                lvwListview.Items[3].ImageIndex = 0;
                lvwListview.Items[4].ImageIndex = 0;

                lvwListview.View = View.Tile;
            }
            catch (Exception error) {
                MessageBox.Show(error.Message,"Error");
            }
        }

       

        private void lstListview_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MessageBox.Show(e.Item.ToString(),"Item Checked");
        }

        private void lstListview_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt_Valor1.Text = lvwListview.Items[lvwListview.FocusedItem.Index].Text;
            this.txt_Valor2.Text = lvwListview.Items[lvwListview.FocusedItem.Index].SubItems[1].Text;
            this.txt_Valor3.Text = lvwListview.Items[lvwListview.FocusedItem.Index].SubItems[2].Text;

        }

         
    }
}