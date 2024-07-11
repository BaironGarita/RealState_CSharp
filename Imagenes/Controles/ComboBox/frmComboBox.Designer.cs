namespace Controles
{
    partial class frmComboBox
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
            this.cmbEscoger = new System.Windows.Forms.ComboBox();
            this.lblEscoger = new System.Windows.Forms.Label();
            this.cmbResultado = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEscoger
            // 
            this.cmbEscoger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscoger.FormattingEnabled = true;
            this.cmbEscoger.Location = new System.Drawing.Point(104, 26);
            this.cmbEscoger.Name = "cmbEscoger";
            this.cmbEscoger.Size = new System.Drawing.Size(170, 28);
            this.cmbEscoger.TabIndex = 0;
            this.cmbEscoger.SelectionChangeCommitted += new System.EventHandler(this.cmbEscoger_SelectionChangeCommitted);
            // 
            // lblEscoger
            // 
            this.lblEscoger.AutoSize = true;
            this.lblEscoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscoger.Location = new System.Drawing.Point(12, 26);
            this.lblEscoger.Name = "lblEscoger";
            this.lblEscoger.Size = new System.Drawing.Size(68, 20);
            this.lblEscoger.TabIndex = 1;
            this.lblEscoger.Text = "Escoger";
            // 
            // cmbResultado
            // 
            this.cmbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResultado.FormattingEnabled = true;
            this.cmbResultado.Location = new System.Drawing.Point(104, 103);
            this.cmbResultado.Name = "cmbResultado";
            this.cmbResultado.Size = new System.Drawing.Size(170, 28);
            this.cmbResultado.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(309, 157);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 55);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 219);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbResultado);
            this.Controls.Add(this.lblEscoger);
            this.Controls.Add(this.cmbEscoger);
            this.Name = "frmComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.frmComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscoger;
        private System.Windows.Forms.Label lblEscoger;
        private System.Windows.Forms.ComboBox cmbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}