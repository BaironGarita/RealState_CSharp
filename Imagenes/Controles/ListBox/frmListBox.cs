using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

         
        private void lstUno_Click(object sender, EventArgs e)
        {

            try
            {
                if (lstUno.Items.Count > 0)
                {
                    // agrega en la segunda lista
                    lstDos.Items.Add(lstUno.SelectedItem);

                    // remueve de la lista el seleccionado
                    //lstUno.Items.RemoveAt(lstUno.SelectedIndex);
                    lstUno.Items.Remove(lstUno.SelectedItem);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atención");
            }
        }

        private void lstDos_Click(object sender, EventArgs e)
        {

            MessageBox.Show(((Comida)lstDos.SelectedItem).ToString(), "Selección");

        }

        private void frmListBox_Load(object sender, EventArgs e)
        {

            try
            {
                // limpiar las lista
                lstUno.Items.Clear();
                lstDos.Items.Clear();

                // Ver la sintaxis 
                lstUno.Items.Add(new Comida() { Id = "1", Descripcion = "Hamburguesa" });
                lstUno.Items.Add(new Comida() { Id = "2", Descripcion = "Tacos" });
                lstUno.Items.Add(new Comida() { Id = "3", Descripcion = "Pizza" });

                lstUno.Items.Add(new Comida()
                {
                    Id = "4",
                    Descripcion = "Burritos"
                });


                // C# mayor 4.X
                Comida oComida = new Comida()
                {
                    Id = "5",
                    Descripcion = "Lasagna"
                };

                 
                lstUno.Items.Add(oComida);

                //Java
                Comida oComida2 = new Comida();
                oComida2.Id = "6";
                oComida2.Descripcion = "Ravioles";

                lstUno.Items.Add(oComida2);

                Comida oSushi = new Comida()
                {
                    Id = "7",
                    Descripcion = "Sushi"
                };

                lstUno.Items.Add(oSushi);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atención");
            } 

        } 

    }
}