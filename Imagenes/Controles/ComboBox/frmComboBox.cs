using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
                        
            String[] arreglo = { "Alajuela", "San Jose", "Heredia", "Guanacaste", "Limón" };

            int contador = 0;
            // cargar los valores por defecto en el combo
            foreach (String item in arreglo)
            {
                contador++;
                // Crea el Objeto
                Provincia oProvincia = new Provincia();
                 
                // Asignar
                oProvincia.Id = contador.ToString();
                oProvincia.Descripcion = item;

                // Agregar el objeto en el combo
                this.cmbEscoger.Items.Add(oProvincia);
                  
            }

            // Colocar visible el primer elemento del Combo
            this.cmbEscoger.SelectedIndex = 0;

        }

        private void cmbEscoger_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String resultado = "";
            
            Provincia provincia = (Provincia)cmbEscoger.SelectedItem;

            resultado = ((Provincia)cmbEscoger.SelectedItem).Id + " ";
            resultado += ((Provincia)cmbEscoger.SelectedItem).Descripcion;

            this.cmbResultado.Items.Add(cmbEscoger.SelectedItem);
             
            // Muestra el item que se escogió
            MessageBox.Show($"Ud escogió {resultado} ", "Selección");

        }

    }
}