namespace Controles
{
    partial class frmConversionesdeTipo
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
            this.btnCualquierTipoAString = new System.Windows.Forms.Button();
            this.btnConversiondetipo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCualquierTipoAString
            // 
            this.btnCualquierTipoAString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCualquierTipoAString.Location = new System.Drawing.Point(108, 45);
            this.btnCualquierTipoAString.Name = "btnCualquierTipoAString";
            this.btnCualquierTipoAString.Size = new System.Drawing.Size(301, 76);
            this.btnCualquierTipoAString.TabIndex = 0;
            this.btnCualquierTipoAString.Text = "Cualquier Tipo a String";
            this.btnCualquierTipoAString.UseVisualStyleBackColor = true;
            this.btnCualquierTipoAString.Click += new System.EventHandler(this.btnCualquierTipoAString_Click);
            // 
            // btnConversiondetipo
            // 
            this.btnConversiondetipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversiondetipo.Location = new System.Drawing.Point(108, 153);
            this.btnConversiondetipo.Name = "btnConversiondetipo";
            this.btnConversiondetipo.Size = new System.Drawing.Size(301, 80);
            this.btnConversiondetipo.TabIndex = 1;
            this.btnConversiondetipo.Text = "Conversiòn de Tipos";
            this.btnConversiondetipo.UseVisualStyleBackColor = true;
            this.btnConversiondetipo.Click += new System.EventHandler(this.btnConversiondetipo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConversionesdeTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConversiondetipo);
            this.Controls.Add(this.btnCualquierTipoAString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmConversionesdeTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversiones de Tipo";
            this.Load += new System.EventHandler(this.frmConversionesdeTipo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCualquierTipoAString;
        private System.Windows.Forms.Button btnConversiondetipo;
        private System.Windows.Forms.Button btnSalir;
    }
}