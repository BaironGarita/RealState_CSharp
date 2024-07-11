using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmDataTimePicker : Form
    {
        public frmDataTimePicker()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            DateTime fecha;
            fecha = DateTime.Now;
            fecha = fecha.AddDays(50);
             

            lstFecha.Items.Clear();
            lstFecha.Items.Add("Value " + dtpFecha.Value);
            lstFecha.Items.Add("Value.Date " + dtpFecha.Value.Date);
            lstFecha.Items.Add("Value.Day " + dtpFecha.Value.Day);
            lstFecha.Items.Add("Value.DayOfWeek " + dtpFecha.Value.DayOfWeek);
            lstFecha.Items.Add("Value.DayOfYear " + dtpFecha.Value.DayOfYear);
            lstFecha.Items.Add("Value.Hour " + dtpFecha.Value.Hour);
            lstFecha.Items.Add("Value.Minute " + dtpFecha.Value.Minute);
            lstFecha.Items.Add("Value.Month " + dtpFecha.Value.Month);
            lstFecha.Items.Add("Value.Year " + dtpFecha.Value.Year);
            lstFecha.Items.Add("Value.ToShortDateString() " + dtpFecha.Value.ToShortDateString());
            lstFecha.Items.Add("Value.ToString() " + dtpFecha.Value.ToString());
            lstFecha.Items.Add("Sumar 5 Días Value.AddDays(5) " + dtpFecha.Value.AddDays(5));
            lstFecha.Items.Add("Sumar 5 Horas Value.AddHours(5) " + dtpFecha.Value.AddHours(5));
            lstFecha.Items.Add("Sumar 5 Años Value.AddYears(5) " + dtpFecha.Value.AddYears(5));
            lstFecha.Items.Add("Sumar 5 Meses Value.AddMonths(5) " + dtpFecha.Value.AddMonths(5));
            lstFecha.Items.Add("Resta 5 Años Value.AddYears(-5) " + dtpFecha.Value.AddYears(-5));

        }

        private void btnRestarFecha_Click(object sender, EventArgs e)
        {

            DateTime fecha1;
            DateTime fecha2;
           
            // Leer el contenido del DateTimePickeer
            fecha1 = dtpFecha.Value;
            // Extraer fecha del sistema
            fecha2 = DateTime.Now;

            // Restar Fechas
            TimeSpan fecha = fecha2.Subtract(fecha1);

            MessageBox.Show(fecha.TotalDays.ToString(), "Resta");

        }

        private void frmDataTimePicker_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {

            

        }
    }
}
