
namespace Controles
{
    partial class frmWebService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lkbLink = new System.Windows.Forms.LinkLabel();
            this.lblNasa = new System.Windows.Forms.Label();
            this.rdbgetAllSatellites = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rdbgetAllGroundStations = new System.Windows.Forms.RadioButton();
            this.rdbrdbgetAllSpaseObservatories = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(524, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 82);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(377, 150);
            this.dgvDatos.TabIndex = 2;
            // 
            // lkbLink
            // 
            this.lkbLink.AutoSize = true;
            this.lkbLink.Location = new System.Drawing.Point(12, 36);
            this.lkbLink.Name = "lkbLink";
            this.lkbLink.Size = new System.Drawing.Size(331, 13);
            this.lkbLink.TabIndex = 3;
            this.lkbLink.TabStop = true;
            this.lkbLink.Text = "https://sscweb.gsfc.nasa.gov/WebServices/SOAP/CsExample.html";
            this.lkbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbLink_LinkClicked);
            // 
            // lblNasa
            // 
            this.lblNasa.AutoSize = true;
            this.lblNasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasa.Location = new System.Drawing.Point(12, 9);
            this.lblNasa.Name = "lblNasa";
            this.lblNasa.Size = new System.Drawing.Size(152, 20);
            this.lblNasa.TabIndex = 4;
            this.lblNasa.Text = "Conexion a la NASA";
            // 
            // rdbgetAllSatellites
            // 
            this.rdbgetAllSatellites.AutoSize = true;
            this.rdbgetAllSatellites.Checked = true;
            this.rdbgetAllSatellites.Location = new System.Drawing.Point(407, 82);
            this.rdbgetAllSatellites.Name = "rdbgetAllSatellites";
            this.rdbgetAllSatellites.Size = new System.Drawing.Size(99, 17);
            this.rdbgetAllSatellites.TabIndex = 5;
            this.rdbgetAllSatellites.TabStop = true;
            this.rdbgetAllSatellites.Text = "getAllSatellites()";
            this.rdbgetAllSatellites.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(407, 207);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar la NASA";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rdbgetAllGroundStations
            // 
            this.rdbgetAllGroundStations.AutoSize = true;
            this.rdbgetAllGroundStations.Location = new System.Drawing.Point(407, 106);
            this.rdbgetAllGroundStations.Name = "rdbgetAllGroundStations";
            this.rdbgetAllGroundStations.Size = new System.Drawing.Size(130, 17);
            this.rdbgetAllGroundStations.TabIndex = 7;
            this.rdbgetAllGroundStations.Text = "getAllGroundStations()";
            this.rdbgetAllGroundStations.UseVisualStyleBackColor = true;
            // 
            // rdbrdbgetAllSpaseObservatories
            // 
            this.rdbrdbgetAllSpaseObservatories.AutoSize = true;
            this.rdbrdbgetAllSpaseObservatories.Location = new System.Drawing.Point(407, 130);
            this.rdbrdbgetAllSpaseObservatories.Name = "rdbrdbgetAllSpaseObservatories";
            this.rdbrdbgetAllSpaseObservatories.Size = new System.Drawing.Size(167, 17);
            this.rdbrdbgetAllSpaseObservatories.TabIndex = 8;
            this.rdbrdbgetAllSpaseObservatories.TabStop = true;
            this.rdbrdbgetAllSpaseObservatories.Text = "rdbgetAllSpaseObservatories()";
            this.rdbrdbgetAllSpaseObservatories.UseVisualStyleBackColor = true;
            // 
            // frmWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 242);
            this.Controls.Add(this.rdbrdbgetAllSpaseObservatories);
            this.Controls.Add(this.rdbgetAllGroundStations);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rdbgetAllSatellites);
            this.Controls.Add(this.lblNasa);
            this.Controls.Add(this.lkbLink);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmWebService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legacy Web Service";
            this.Load += new System.EventHandler(this.frmWebService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.LinkLabel lkbLink;
        private System.Windows.Forms.Label lblNasa;
        private System.Windows.Forms.RadioButton rdbgetAllSatellites;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rdbgetAllGroundStations;
        private System.Windows.Forms.RadioButton rdbrdbgetAllSpaseObservatories;
    }
}