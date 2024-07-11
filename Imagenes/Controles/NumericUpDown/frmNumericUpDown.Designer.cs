namespace Controles
{
    partial class frmNumericUpDown
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
            this.nUDNumerico = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.nUDincrementador = new System.Windows.Forms.NumericUpDown();
            this.lblIncrementador = new System.Windows.Forms.Label();
            this.lbllista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDincrementador)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDNumerico
            // 
            this.nUDNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDNumerico.Location = new System.Drawing.Point(24, 29);
            this.nUDNumerico.Name = "nUDNumerico";
            this.nUDNumerico.Size = new System.Drawing.Size(147, 24);
            this.nUDNumerico.TabIndex = 0;
            this.nUDNumerico.ValueChanged += new System.EventHandler(this.nUDNumerico_ValueChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(229, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 51);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.SystemColors.Info;
            this.lstLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 18;
            this.lstLista.Location = new System.Drawing.Point(24, 69);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(147, 112);
            this.lstLista.TabIndex = 2;
            // 
            // nUDincrementador
            // 
            this.nUDincrementador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDincrementador.Location = new System.Drawing.Point(240, 29);
            this.nUDincrementador.Name = "nUDincrementador";
            this.nUDincrementador.Size = new System.Drawing.Size(72, 24);
            this.nUDincrementador.TabIndex = 3;
            this.nUDincrementador.ValueChanged += new System.EventHandler(this.nUDincrementador_ValueChanged);
            // 
            // lblIncrementador
            // 
            this.lblIncrementador.AutoSize = true;
            this.lblIncrementador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncrementador.Location = new System.Drawing.Point(237, 6);
            this.lblIncrementador.Name = "lblIncrementador";
            this.lblIncrementador.Size = new System.Drawing.Size(103, 18);
            this.lblIncrementador.TabIndex = 4;
            this.lblIncrementador.Text = "Incrementador";
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllista.Location = new System.Drawing.Point(25, 6);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(94, 18);
            this.lbllista.TabIndex = 5;
            this.lbllista.Text = "Agregar Lista";
            // 
            // frmNumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 191);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.lblIncrementador);
            this.Controls.Add(this.nUDincrementador);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.nUDNumerico);
            this.Name = "frmNumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDincrementador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDNumerico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.NumericUpDown nUDincrementador;
        private System.Windows.Forms.Label lblIncrementador;
        private System.Windows.Forms.Label lbllista;
    }
}