using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{

    public partial class frmLambdaExpresions : Form
    {

        private List<Persona> _ListaPersonas;

        public frmLambdaExpresions()
        {
              
            InitializeComponent();
        }

        private void frmLambdaExpresions_Load(object sender, EventArgs e)
        {
            try
            {
               
                _ListaPersonas = new List<Persona>();
                CargarXML();
                this.dgvDatos.DataSource = _ListaPersonas;

            }
            catch (Exception error)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Error          : {0}\n", error.Message);
                msg.AppendFormat("Source         : {0}\n", error.Source);
                msg.AppendFormat("StackTrace     : {0}\n", error.StackTrace);
                msg.AppendFormat("Data           : {0}\n", error.Data);
                msg.AppendFormat("InnerException : {0}\n", error.InnerException);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CargarXML()
        {
            String ruta = @"..\..\Lambdas\Archivo.xml";

            DataSet ds = new DataSet();

            ds.ReadXml(ruta);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Persona oPersona = new Persona()
                {
                    Cedula = item[0].ToString(),
                    Nombre = item[1].ToString(),
                    Apellidos = item[2].ToString(),
                    Salario = double.Parse(item[3].ToString())
                };

                _ListaPersonas.Add(oPersona);
            }
        }


        private void btnEjecutar_Click_1(object sender, EventArgs e)
        {
            bool respuesta = false;
            this.dgvRespuestas.DataSource = null;
            List<Persona> listaPersonaTemporal = new List<Persona>();
            try
            {

                if (rdbExist.Checked)
                {
                    respuesta = _ListaPersonas.Exists(a => a.Nombre.Equals(this.txtExiste.Text,StringComparison.InvariantCultureIgnoreCase) == true);

                    MessageBox.Show("Respuesta :" + respuesta.ToString()  );
                    return;
                }

                // Encontrar
                if (this.rdbFind.Checked)
                {
                    //foreach (Persona item in _ListaPersonas)
                    //{
                    //    if (item.Cedula == txtFind.Text) {
                    //        Persona persona = item;
                    //    }
                    //}
                    Persona oPersona = _ListaPersonas.Find(h => h.Cedula == this.txtFind.Text);

                    if (oPersona != null)
                    {
                        //MessageBox.Show("Respuesta " + oPersona.ToString(), "Lambda");
                        listaPersonaTemporal.Add(oPersona);
                        this.dgvRespuestas.DataSource = listaPersonaTemporal;
                    }
                    else
                    {
                        MessageBox.Show("Respuesta No existe", "Lambda");
                    }
                }

                // Ordena
                if (this.rdbOrderBy.Checked)
                {
                    listaPersonaTemporal = _ListaPersonas.OrderBy(f => f.Salario).ToList();
                    this.dgvRespuestas.DataSource = listaPersonaTemporal;                  
                }

                if (this.rdbFindAll.Checked)
                {
                    //List<Persona> tempSalario = new List<Persona>();
                    //foreach (Persona item in _ListaPersonas)
                    //{
                    //    if (item.Salario <= Convert.ToInt32(this.mskFindAll.Text))
                    //    {
                    //        tempSalario.Add(item);
                    //    }
                    //}
                                        

                    listaPersonaTemporal = _ListaPersonas.FindAll(p => p.Salario <= int.Parse(this.mskFindAll.Text));
                    this.dgvRespuestas.DataSource = listaPersonaTemporal;

                }

                if (this.rdbForEach.Checked)
                {
                    //// Forma 1
                    //List<Persona> tempSalario = new List<Persona>();
                    //foreach (var item in _ListaPersonas)
                    //{
                    //    item.Salario = item.Salario * 1.10;
                    //    tempSalario.Add(item);
                    //}
                    //// Forma 2 y mejor
                    //for (int i = 0; i < _ListaPersonas.Count -1; i++)
                    //{
                    //    _ListaPersonas[i].Salario = _ListaPersonas[i].Salario * 1.10;
                    //}


                    _ListaPersonas.ForEach(s => s.Salario = s.Salario * 1.10);
                    this.dgvRespuestas.DataSource = _ListaPersonas;
                }

                if (this.rdbMax.Checked)
                {
                    double @double = _ListaPersonas.Max(s => s.Salario);
                    MessageBox.Show("El salario MAS ALTO es de " + @double.ToString(), "Atencion");
                 }

                if (rdbTake.Checked)
                {
                    IEnumerable<Persona> lista = _ListaPersonas.Take(2);
                    this.dgvRespuestas.DataSource = lista.ToList();
                 
                }
            }
            catch (Exception error)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Error          : {0}\n", error.Message);
                msg.AppendFormat("Source         : {0}\n", error.Source);
                msg.AppendFormat("StackTrace     : {0}\n", error.StackTrace);
                msg.AppendFormat("Data           : {0}\n", error.Data);
                msg.AppendFormat("InnerException : {0}\n", error.InnerException);


                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void linkbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.linkbl.Text);
        }
    }
}
