namespace Controles
{
    partial class frmState
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
            this.pnlVerde = new System.Windows.Forms.Panel();
            this.pnlAmarillo = new System.Windows.Forms.Panel();
            this.pnlRojo = new System.Windows.Forms.Panel();
            this.btnNuevoEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 58);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlVerde
            // 
            this.pnlVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlVerde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVerde.Location = new System.Drawing.Point(51, 31);
            this.pnlVerde.Name = "pnlVerde";
            this.pnlVerde.Size = new System.Drawing.Size(120, 76);
            this.pnlVerde.TabIndex = 1;
            // 
            // pnlAmarillo
            // 
            this.pnlAmarillo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmarillo.Location = new System.Drawing.Point(51, 119);
            this.pnlAmarillo.Name = "pnlAmarillo";
            this.pnlAmarillo.Size = new System.Drawing.Size(120, 72);
            this.pnlAmarillo.TabIndex = 2;
            // 
            // pnlRojo
            // 
            this.pnlRojo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRojo.Location = new System.Drawing.Point(51, 207);
            this.pnlRojo.Name = "pnlRojo";
            this.pnlRojo.Size = new System.Drawing.Size(120, 75);
            this.pnlRojo.TabIndex = 3;
            // 
            // btnNuevoEstado
            // 
            this.btnNuevoEstado.Location = new System.Drawing.Point(256, 163);
            this.btnNuevoEstado.Name = "btnNuevoEstado";
            this.btnNuevoEstado.Size = new System.Drawing.Size(111, 55);
            this.btnNuevoEstado.TabIndex = 4;
            this.btnNuevoEstado.Text = "Siguente Estado";
            this.btnNuevoEstado.UseVisualStyleBackColor = true;
            this.btnNuevoEstado.Click += new System.EventHandler(this.btnNuevoEstado_Click);
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.btnNuevoEstado);
            this.Controls.Add(this.pnlRojo);
            this.Controls.Add(this.pnlAmarillo);
            this.Controls.Add(this.pnlVerde);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.Load += new System.EventHandler(this.frmState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlVerde;
        private System.Windows.Forms.Panel pnlAmarillo;
        private System.Windows.Forms.Panel pnlRojo;
        private System.Windows.Forms.Button btnNuevoEstado;
    }
}