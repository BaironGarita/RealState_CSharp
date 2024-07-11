using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Modificado 02-02-2022 
/// 
/// Convertir json to c# https://json2csharp.com/
/// 
/// </summary>

namespace Controles
{

    public partial class frmWebApi : Form
    {
        public frmWebApi()
        {
            InitializeComponent();
        }

        private void frmWebApi_Load(object sender, EventArgs e)
        {
            // Elimine el rows en blanco para que no se vea feo
            dgvDatos.AllowUserToAddRows = false;
        }

        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string parametro = "", url = "";

            List<Pais> lista = null;
            HttpWebRequest request = null;
            if (string.IsNullOrEmpty(txtPais.Text))
            {
                txtPais.Focus();
                return;
            }

            this.dgvDatos.Rows.Clear();

            parametro = this.txtPais.Text.Trim();
            url = $"https://restcountries.com/v3.1/name/{parametro}";
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            string responseBodyJSON = "";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)
                            return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBodyJSON = objReader.ReadToEnd();

                            if (!string.IsNullOrEmpty(responseBodyJSON))
                            {

                                lista =  Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pais>>(responseBodyJSON);
                                // JSONGeneric<List<Pais>>.JSonToObject(responseBody);
                                // lista = (List<Pais>)JSONGeneric<List<Pais>>.JSonToObject(responseBody);

                            }
                        }
                    }
                }

                // No autogenere columnas
                this.dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Resizable = DataGridViewTriState.True;
                // Altura del Row para que se vea bien la bandera
                dgvDatos.RowTemplate.Height = 50;
                // Elimine el rows en blanco para que no se vea feo
                dgvDatos.AllowUserToAddRows = false;

                // Itere la lista
                foreach (var item in lista)
                {
                    // Extraiga con el URL la imagen y la retorna en un array de bytes
                    byte[] byteArray = DownloadImageFromUrl(item.Flags.Png);
                    this.dgvDatos.Rows.Add(new object[] { item.Name.Official, byteArray });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se ajustó rutina https://forgetcode.com/csharp/2052-download-images-from-a-url
        /// Descarga una imagen desde internet y retorna un arreglo de bytes
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public byte[] DownloadImageFromUrl(string url)
        {
            Image image = null;
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                using (WebResponse webResponse = webRequest.GetResponse())
                { 
                    Stream stream = webResponse.GetResponseStream();
                    image = System.Drawing.Image.FromStream(stream);

                    using (MemoryStream memory = new MemoryStream())
                    {
                        // Convierta a jpg
                        image.Save(memory, ImageFormat.Jpeg);
                        // Retorne el bytes array
                        return memory.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                return null;
            } 
        }


         

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
