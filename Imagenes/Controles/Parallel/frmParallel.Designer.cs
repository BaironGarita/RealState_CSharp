
namespace Controles
{
    partial class frmParallel
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
            this.lstPar = new System.Windows.Forms.ListBox();
            this.lstImpar = new System.Windows.Forms.ListBox();
            this.lstUrls = new System.Windows.Forms.ListBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.lblPar = new System.Windows.Forms.Label();
            this.lbImpar = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(430, 195);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstPar
            // 
            this.lstPar.FormattingEnabled = true;
            this.lstPar.Location = new System.Drawing.Point(19, 129);
            this.lstPar.Name = "lstPar";
            this.lstPar.Size = new System.Drawing.Size(127, 108);
            this.lstPar.TabIndex = 2;
            // 
            // lstImpar
            // 
            this.lstImpar.FormattingEnabled = true;
            this.lstImpar.Location = new System.Drawing.Point(152, 129);
            this.lstImpar.Name = "lstImpar";
            this.lstImpar.Size = new System.Drawing.Size(120, 108);
            this.lstImpar.TabIndex = 3;
            // 
            // lstUrls
            // 
            this.lstUrls.FormattingEnabled = true;
            this.lstUrls.HorizontalScrollbar = true;
            this.lstUrls.Location = new System.Drawing.Point(278, 129);
            this.lstUrls.Name = "lstUrls";
            this.lstUrls.Size = new System.Drawing.Size(118, 108);
            this.lstUrls.TabIndex = 4;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(19, 12);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(152, 42);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar Procesos Paralelos";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(19, 60);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar Procesos";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(19, 243);
            this.pgbBarra.Maximum = 1000;
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(504, 23);
            this.pgbBarra.Step = 1;
            this.pgbBarra.TabIndex = 7;
            // 
            // lblPar
            // 
            this.lblPar.AutoSize = true;
            this.lblPar.Location = new System.Drawing.Point(19, 110);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(23, 13);
            this.lblPar.TabIndex = 8;
            this.lblPar.Text = "Par";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Location = new System.Drawing.Point(152, 110);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(33, 13);
            this.lbImpar.TabIndex = 9;
            this.lbImpar.Text = "Impar";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(278, 110);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "Url";
            // 
            // frmParallel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 276);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lbImpar);
            this.Controls.Add(this.lblPar);
            this.Controls.Add(this.pgbBarra);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.lstUrls);
            this.Controls.Add(this.lstImpar);
            this.Controls.Add(this.lstPar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmParallel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parallel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParallel_FormClosing);
            this.Load += new System.EventHandler(this.frmParallel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstPar;
        private System.Windows.Forms.ListBox lstImpar;
        private System.Windows.Forms.ListBox lstUrls;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lblUrl;
    }
}