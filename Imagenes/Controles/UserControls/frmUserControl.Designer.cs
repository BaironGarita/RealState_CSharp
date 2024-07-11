namespace Controles
{
    partial class frmUserControl
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
            this.tspEncriptar = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnEncriptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnComprimir = new System.Windows.Forms.ToolStripButton();
            this.tspEncriptar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspEncriptar
            // 
            this.tspEncriptar.AutoSize = false;
            this.tspEncriptar.BackColor = System.Drawing.SystemColors.Control;
            this.tspEncriptar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspEncriptar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEncriptar,
            this.toolStripBtnSalir,
            this.toolStripBtnComprimir});
            this.tspEncriptar.Location = new System.Drawing.Point(0, 0);
            this.tspEncriptar.Name = "tspEncriptar";
            this.tspEncriptar.Size = new System.Drawing.Size(120, 395);
            this.tspEncriptar.TabIndex = 0;
            this.tspEncriptar.Text = "toolStrip1";
            // 
            // toolStripBtnEncriptar
            // 
            this.toolStripBtnEncriptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnEncriptar.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnEncriptar.Image = global::Controles.Properties.Resources.finished_work;
            this.toolStripBtnEncriptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEncriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEncriptar.Name = "toolStripBtnEncriptar";
            this.toolStripBtnEncriptar.Size = new System.Drawing.Size(118, 36);
            this.toolStripBtnEncriptar.Text = "Encriptar";
            this.toolStripBtnEncriptar.Click += new System.EventHandler(this.toolStripBtnEncriptar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSalir.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnSalir.Image = global::Controles.Properties.Resources.logout1;
            this.toolStripBtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(108, 36);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // toolStripBtnComprimir
            // 
            this.toolStripBtnComprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnComprimir.Image = global::Controles.Properties.Resources.future_projects;
            this.toolStripBtnComprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnComprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnComprimir.Name = "toolStripBtnComprimir";
            this.toolStripBtnComprimir.Size = new System.Drawing.Size(118, 36);
            this.toolStripBtnComprimir.Text = "Comprimir";
            this.toolStripBtnComprimir.Click += new System.EventHandler(this.toolStripBtnComprimir_Click);
            // 
            // frmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(716, 395);
            this.Controls.Add(this.tspEncriptar);
            this.Name = "frmUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControl";
            this.Load += new System.EventHandler(this.frmUserControl_Load);
            this.tspEncriptar.ResumeLayout(false);
            this.tspEncriptar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripBtnEncriptar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        public System.Windows.Forms.ToolStrip tspEncriptar;
        private System.Windows.Forms.ToolStripButton toolStripBtnComprimir;
    }
}