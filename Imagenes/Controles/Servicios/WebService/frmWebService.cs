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


/// <summary>
/// https://sscweb.gsfc.nasa.gov/WebServices/SOAP/CsExample.html
/// https://sscweb.gsfc.nasa.gov/WebServices/SOAP/
/// </summary>
namespace Controles
{
    public partial class frmWebService : Form
    {
        public frmWebService()
        {
            InitializeComponent();
        }

        private void frmWebService_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
 

        private void lkbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((sender as LinkLabel).Text);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Agente.SatelliteSituationCenterService service = new Agente.SatelliteSituationCenterService();

            try
            {
                this.dgvDatos.AutoGenerateColumns = true;
                this.dgvDatos.DataSource = null;

                if (rdbgetAllSatellites.Checked) {
                     Agente.satelliteDescription[] satellites =  service.getAllSatellites();
                    this.dgvDatos.DataSource = satellites;
                }

                if (rdbgetAllGroundStations.Checked)
                {
                    Agente.groundStationDescription[] stationDescriptions = service.getAllGroundStations(); ;
                    this.dgvDatos.DataSource = stationDescriptions;
                }

                if (rdbrdbgetAllSpaseObservatories.Checked)
                {
                    Agente.spaseObservatoryDescription[] spaceObservatory = service.getAllSpaseObservatories(); ;
                    this.dgvDatos.DataSource = spaceObservatory;
                }
                 
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
             
        }
    }
}
