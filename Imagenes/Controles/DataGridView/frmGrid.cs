using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace Controles
{
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            InitializeComponent();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            try
            {
                
                dgvGrid.Rows.Clear();
                // Eliminar la fila de más
                dgvGrid.AllowUserToAddRows = false;
                // registro para introducir en el grid
                String[] registro1 = { "123", "Leo" };
                String[] registro2 = { "321", "María" };
                String[] registro3 = { "789", "Sonia" };

                // Agregar el Registro al Grid
                dgvGrid.Rows.Add(registro1);
                dgvGrid.Rows.Add(registro2);
                dgvGrid.Rows.Add(registro3);
                dgvGrid.Rows.Add(new string[] { "543", "Vilma" });
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("InnerException {0}\n", error.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);

                MessageBox.Show(msg.ToString(), "Error");
            }


        }

        private void dgvGrid_CellClick(object sender, 
                                       DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
                try // Atrapar el error en caso de que se haga click en una 
                // columna sin datos ! 
                {
                    MessageBox.Show(dgvGrid[0, e.RowIndex].Value.ToString());
                }
                catch (Exception error)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat("Mensaje        {0}\n", error.Message);
                    msg.AppendFormat("Source         {0}\n", error.Source);
                    msg.AppendFormat("InnerException {0}\n", error.InnerException);
                    msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);

                    MessageBox.Show(msg.ToString(), "Error");
                }

        }

        private void frmGrid_Load(object sender, EventArgs e)
        {


        }



        private void btnLlenarList_Click(object sender, EventArgs e)
        {

            try
            {
                dgvEmpleado.AutoGenerateColumns = false;
                // limpiar el Datagridview
                dgvEmpleado.DataSource = null;

                List<Empleado> listaEmpleado = new List<Empleado>();

                Empleado oEmpleado1 = new Empleado();
                oEmpleado1.Id = "234";
                oEmpleado1.Nombre = "Rebeca";

                Empleado oEmpleado2 = new Empleado()
                {
                    Id = "67777",
                    Nombre = "Madonna"
                };

                listaEmpleado.Add(oEmpleado1);
                listaEmpleado.Add(oEmpleado2);

                // Para acceder a las funciones de linq 
                // agregar el using System.Linq;
                listaEmpleado = listaEmpleado.OrderBy(d => d.Nombre).ToList();


                // Agregar el Registro al Grid
                 dgvEmpleado.DataSource = listaEmpleado;
                
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("InnerException {0}\n", error.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);

                MessageBox.Show(msg.ToString(), "Error");
            }




        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
                try // Atrapar el error en caso de que se haga click en una 
                // columna sin datos ! 
                {
                    
                    List<Empleado> listaEmpleado = (List<Empleado>)dgvEmpleado.DataSource;
                    Empleado oEmpleado = listaEmpleado[e.RowIndex] as Empleado;

                    MessageBox.Show($" {oEmpleado.Id}  {oEmpleado.Nombre}");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message, "Atención!");
                }

        }



    }
}