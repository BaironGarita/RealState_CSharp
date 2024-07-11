namespace Controles
{
    partial class frmDataTimePicker
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstFecha = new System.Windows.Forms.ListBox();
            this.btnRestarFecha = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(339, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 60);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(12, 23);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(433, 26);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lstFecha
            // 
            this.lstFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFecha.FormattingEnabled = true;
            this.lstFecha.ItemHeight = 20;
            this.lstFecha.Location = new System.Drawing.Point(12, 62);
            this.lstFecha.Name = "lstFecha";
            this.lstFecha.ScrollAlwaysVisible = true;
            this.lstFecha.Size = new System.Drawing.Size(433, 204);
            this.lstFecha.TabIndex = 2;
            // 
            // btnRestarFecha
            // 
            this.btnRestarFecha.Location = new System.Drawing.Point(12, 276);
            this.btnRestarFecha.Name = "btnRestarFecha";
            this.btnRestarFecha.Size = new System.Drawing.Size(112, 51);
            this.btnRestarFecha.TabIndex = 3;
            this.btnRestarFecha.Text = "Restar fecha";
            this.btnRestarFecha.UseVisualStyleBackColor = true;
            this.btnRestarFecha.Click += new System.EventHandler(this.btnRestarFecha_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(149, 276);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(164, 51);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Cuántos Viernes Tiene 2020?";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // frmDataTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 335);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.btnRestarFecha);
            this.Controls.Add(this.lstFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmDataTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.frmDataTimePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ListBox lstFecha;
        private System.Windows.Forms.Button btnRestarFecha;
        private System.Windows.Forms.Button btnCalculo;
    }
}