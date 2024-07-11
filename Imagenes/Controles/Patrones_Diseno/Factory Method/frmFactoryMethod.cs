using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmFactoryMethod : Form
    {
        public frmFactoryMethod()
        {
            InitializeComponent();
        }

        private void frmFactoryMethod_Load(object sender, EventArgs e)
        {
            CulturaInfo();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IProveedor oProveedor = null;
            Factura oFactura = new Factura();
            int minutos = 0, mensajes = 0;

            try
            { 
                if (this.rdbIce.Checked)
                    oProveedor = FactoryProveedor.ObtenerProveedor(TipoProveedor.ICE);
                else
                    oProveedor = FactoryProveedor.ObtenerProveedor(TipoProveedor.CLARO);

                minutos = int.Parse(this.txtMinutos.Text);

                mensajes = int.Parse(this.txtMensajes.Text);

                oFactura.AsignarProveedor(oProveedor);
                oFactura.AgregarMensajes(mensajes);
                oFactura.AgregarMinutos(minutos);


                this.lstDetalle.Items.Add("----- " + oProveedor.GetType().Name + " -----");

                this.lstDetalle.Items.Add("Monto total a pagar " + oFactura.MontoTotalPagar());



            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error");
            }
        }



        /// <summary>
        /// Tema de formatos de fecha, Culture y formato num/rico
        /// </summary>
        private void CulturaInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;

        }

    }
}
