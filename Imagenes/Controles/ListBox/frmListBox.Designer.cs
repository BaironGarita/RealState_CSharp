namespace Controles
{
    partial class frmListBox
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
            this.lstUno = new System.Windows.Forms.ListBox();
            this.lstDos = new System.Windows.Forms.ListBox();
            this.lblFuente = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(262, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstUno
            // 
            this.lstUno.BackColor = System.Drawing.Color.NavajoWhite;
            this.lstUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUno.FormattingEnabled = true;
            this.lstUno.ItemHeight = 20;
            this.lstUno.Location = new System.Drawing.Point(12, 47);
            this.lstUno.Name = "lstUno";
            this.lstUno.Size = new System.Drawing.Size(178, 144);
            this.lstUno.TabIndex = 1;
            this.lstUno.Click += new System.EventHandler(this.lstUno_Click);
            // 
            // lstDos
            // 
            this.lstDos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lstDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDos.FormattingEnabled = true;
            this.lstDos.ItemHeight = 20;
            this.lstDos.Location = new System.Drawing.Point(262, 47);
            this.lstDos.Name = "lstDos";
            this.lstDos.Size = new System.Drawing.Size(175, 144);
            this.lstDos.TabIndex = 2;
            this.lstDos.Click += new System.EventHandler(this.lstDos_Click);
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuente.Location = new System.Drawing.Point(64, 13);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(60, 20);
            this.lblFuente.TabIndex = 4;
            this.lblFuente.Text = "Fuente";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(319, 13);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(64, 20);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino";
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 273);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblFuente);
            this.Controls.Add(this.lstDos);
            this.Controls.Add(this.lstUno);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstUno;
        private System.Windows.Forms.ListBox lstDos;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.Label lblDestino;
    }
}