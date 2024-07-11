using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmParallel : Form
    {

        private Thread _Hilo;
        private int pares = 0, impares = 0;
        private CancellationTokenSource cts = new CancellationTokenSource();

        public frmParallel()
        {
            InitializeComponent();
        }

        private void frmParallel_Load(object sender, EventArgs e)
        {

        }


        private void btnEjecutar_Click(object sender, EventArgs e)
        {

            try
            {
                this.lstPar.Items.Clear();
                this.lstImpar.Items.Clear();
                this.lstUrls.Items.Clear();

                // Se inicio hilo y se pasa el method Paralelo
                _Hilo = new Thread(Paralelo);
                _Hilo.Start();
            }
            catch (Exception err)
            {

                MessageBox.Show($"Erro {err.Message}", "Error");
            }
        }

        /// <summary>
        /// Procesos paralelos
        /// </summary>
        private void Paralelo()
        {

            try
            {
                cts = new CancellationTokenSource();
                // Opciones de Parallel
                ParallelOptions options = new ParallelOptions();
                options.CancellationToken = cts.Token;

                // Invocar de forma paralela a dos métodos
                Parallel.Invoke(options,
                                        () => pares = Pares(cts.Token),
                                        () => impares = Impares(cts.Token),
                                        () => GetDataFromURL(cts.Token),
                                        () => ProgressBar(cts.Token)
                                        );
            }
            catch (AggregateException e)
            {
                Exception cause = e.InnerExceptions[0];
                MessageBox.Show($"Error {cause.Message} ");
            }

        }

        /// <summary>
        /// Numero pares
        /// </summary>
        /// <param name="ct">CancellationToken</param>
        /// <returns></returns>
        private int Pares(CancellationToken ct)
        {
            int contador = 0;
            for (int i = 0; i < 100; i++)
            {
                // Cancela la solicitud
                if (ct.IsCancellationRequested)
                {
                    return 0;
                }

                if (i % 2 == 0)
                {
                    if (lstPar.InvokeRequired)
                    {
                        lstPar.Invoke((MethodInvoker)delegate
                        {
                            lstPar.Items.Add(i);
                        });
                    }
                    contador++;

                }
                Thread.Sleep(500);
            }
            return contador;

        }


        /// <summary>
        /// Numeros Impares
        /// </summary>
        /// <param name="ct">CancellationToken</param>
        /// <returns></returns>
        private int Impares(CancellationToken ct)
        {
            int contador = 0;
            for (int i = 0; i < 100; i++)
            {
                // Cancela la solicitud
                if (ct.IsCancellationRequested)
                {
                    return 0;
                }

                if (i % 2 != 0)
                {
                    if (lstPar.InvokeRequired)
                    {
                        lstImpar.Invoke((MethodInvoker)delegate
                    {
                        lstImpar.Items.Add(i);
                    });
                        contador++;
                    }
                }
                Thread.Sleep(1000);
            }
            return contador;
        }


        private void ProgressBar(CancellationToken ct)
        {

            for (int i = 0; i < 1000; i++)
            {
                // Cancela la solicitud
                if (ct.IsCancellationRequested)
                {
                    return;
                }

                if (this.pgbBarra.InvokeRequired)
                {
                    pgbBarra.Invoke((MethodInvoker)delegate
                    {
                        pgbBarra.Value = i;
                    });
                }

                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// Obtiene datos de urls y cuenta la cantidad de espacios en blanco
        /// </summary>
        /// <param name="ct">CancellationToken</param>
        private void GetDataFromURL(CancellationToken ct)
        {
            string datos = "";
            // Declare an HttpClient object.
            WebClient client = new WebClient();
            try
            {


                // Lista con urls
                List<string> urlList = new List<string>();
                urlList.Add(@"https://www.utn.ac.cr/");
                urlList.Add(@"https://www.ucr.ac.cr/");
                urlList.Add(@"https://www.tec.ac.cr/");
                urlList.Add(@"https://www.uned.ac.cr/");

                // ***Add a loop to process the list of web addresses.
                foreach (var url in urlList)
                {
                    // Cancela la solicitud
                    if (ct.IsCancellationRequested)
                    {
                        return;
                    }

                    // Conectarse al url
                    using (Stream data = client.OpenRead(url))
                    {
                        using (StreamReader reader = new StreamReader(data))
                        {
                            datos = reader.ReadToEnd();
                        }
                    };

                    if (lstPar.InvokeRequired)
                    {
                        lstUrls.Invoke((MethodInvoker)delegate
                        {
                            this.lstUrls.Items.Add($"{datos.Split(' ').Count()} - {url}   ");
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.Message, "Error");
            }
        }

        private void frmParallel_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cancela el proceso parallel
            cts.Cancel();
            Close();

        }
    }
}
