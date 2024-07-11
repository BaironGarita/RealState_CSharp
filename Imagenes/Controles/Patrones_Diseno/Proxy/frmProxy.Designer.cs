namespace Controles
{
    partial class frmProxy
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
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.trbVelocidad = new System.Windows.Forms.TrackBar();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 12);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(221, 182);
            this.rtbDatos.TabIndex = 0;
            this.rtbDatos.Text = "Ingenieria de Sofware UTN";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Controles.Properties.Resources.logout2;
            this.btnSalir.Location = new System.Drawing.Point(390, 143);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 56);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // trbVelocidad
            // 
            this.trbVelocidad.Location = new System.Drawing.Point(257, 41);
            this.trbVelocidad.Minimum = -10;
            this.trbVelocidad.Name = "trbVelocidad";
            this.trbVelocidad.Size = new System.Drawing.Size(248, 45);
            this.trbVelocidad.TabIndex = 3;
            this.trbVelocidad.Value = -3;
            // 
            // trbVolumen
            // 
            this.trbVolumen.Location = new System.Drawing.Point(257, 92);
            this.trbVolumen.Maximum = 100;
            this.trbVolumen.Name = "trbVolumen";
            this.trbVolumen.Size = new System.Drawing.Size(248, 45);
            this.trbVolumen.TabIndex = 4;
            this.trbVolumen.Value = 80;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Image = global::Controles.Properties.Resources.audio_card;
            this.btnEjecutar.Location = new System.Drawing.Point(257, 143);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(127, 56);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidad";
            // 
            // frmProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbVolumen);
            this.Controls.Add(this.trbVelocidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.rtbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Pattern";
            this.Load += new System.EventHandler(this.frmProxy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TrackBar trbVelocidad;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}