namespace Controles
{
    partial class frmTabControl
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
            this.tcControl = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.btnInicio = new System.Windows.Forms.Button();
            this.tcControl.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(305, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 34);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tcControl
            // 
            this.tcControl.Controls.Add(this.tp1);
            this.tcControl.Controls.Add(this.tp2);
            this.tcControl.Controls.Add(this.tp3);
            this.tcControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcControl.Location = new System.Drawing.Point(0, 12);
            this.tcControl.Name = "tcControl";
            this.tcControl.SelectedIndex = 0;
            this.tcControl.Size = new System.Drawing.Size(414, 242);
            this.tcControl.TabIndex = 1;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.btnSiguiente1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(406, 213);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Página N1";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente1.Location = new System.Drawing.Point(301, 175);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(102, 34);
            this.btnSiguiente1.TabIndex = 0;
            this.btnSiguiente1.Text = "&Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.btnSiguiente2);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(406, 213);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Página N2";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente2.Location = new System.Drawing.Point(301, 176);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(102, 34);
            this.btnSiguiente2.TabIndex = 1;
            this.btnSiguiente2.Text = "&Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.btnInicio);
            this.tp3.Location = new System.Drawing.Point(4, 25);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(406, 213);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Página N3";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(300, 174);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(102, 34);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "&Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 296);
            this.Controls.Add(this.tcControl);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmTabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControl";
            this.Load += new System.EventHandler(this.frmTabControl_Load);
            this.tcControl.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tcControl;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.Button btnInicio;
    }
}