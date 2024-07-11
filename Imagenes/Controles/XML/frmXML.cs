using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Controles
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        private void btnCrearXML_Click(object sender, EventArgs e)
        {
            try
            {
                // validar si existe el directorio sino lo crea
                if (!Directory.Exists(@"c:\temp"))
                {
                    Directory.CreateDirectory(@"c:\temp");
                }

                StreamWriter xml = new StreamWriter(@"c:\temp\facil.xml");

                XmlDocument documento = new XmlDocument();
                XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", "iso-8859-1", null);
                documento.AppendChild(declaracion);// Se crea la raiz               

                XmlElement raiz = documento.CreateElement("raiz");
                documento.AppendChild(raiz);                 

                #region Persona 1
                XmlElement personas = documento.CreateElement("personas");
                personas.SetAttribute("estado", "Vivo");
                
                XmlElement cedula = documento.CreateElement("cedula");
                cedula.InnerText = "2-0323-0441";
                personas.AppendChild(cedula);

                XmlElement fechanacimiento = documento.CreateElement("fechanacimiento");
                fechanacimiento.InnerText = "01-05-1970";
                personas.AppendChild(fechanacimiento);

                XmlElement nombre = documento.CreateElement("nombre");
                nombre.InnerText = "Omar";
                personas.AppendChild(nombre);

                XmlElement apellido = documento.CreateElement("apellido");
                apellido.InnerText = "Montero";
                personas.AppendChild(apellido);

                XmlElement salario = documento.CreateElement("salario");
                salario.SetAttribute("dolar", "1");
                salario.SetAttribute("colones", "580");
                personas.AppendChild(salario);

                raiz.AppendChild(personas);
                #endregion

                #region Persona 2
                personas = documento.CreateElement("personas");
                personas.SetAttribute("estado", "Muerto de risa");

                cedula = documento.CreateElement("cedula");
                cedula.InnerText = "7-0777-0777";
                personas.AppendChild(cedula);

                fechanacimiento = documento.CreateElement("fechanacimiento");
                fechanacimiento.InnerText = "01-05-1985";
                personas.AppendChild(fechanacimiento);

                nombre = documento.CreateElement("nombre");
                nombre.InnerText = "Maria";
                personas.AppendChild(nombre);

                apellido = documento.CreateElement("apellido");
                apellido.InnerText = "Solis";
                personas.AppendChild(apellido);

                #endregion

                raiz.AppendChild(personas);

                // Salvar el archivo
                xml.Write(documento.OuterXml);
                xml.Close();

                Process.Start(@"c:\temp\facil.xml");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error :" + er.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerMiBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                this.wbNavegador.Url = new Uri(@"c:\temp\facil.xml");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error :" + er.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                //Se crea un dataset
                DataSet ds = new DataSet();
                //Dirección del archivo xml
                ds.ReadXml(@"c:\temp\facil.xml");
                this.dgvDatos.AutoGenerateColumns = true;
                this.dgvDatos.DataSource = ds.Tables[0];

            }
            catch (Exception er)
            {

                MessageBox.Show("Error :" + er.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXML_Load(object sender, EventArgs e)
        {
            try
            {


                if (Directory.Exists(@"C:\temp") == false)
                    Directory.CreateDirectory(@"C:\temp");
            }
            catch (Exception er)
            {

                MessageBox.Show("Error : No pude crear directorio C:\\temp" + er.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
