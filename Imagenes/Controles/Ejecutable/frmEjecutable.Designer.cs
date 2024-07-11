namespace Controles
{
    partial class frmEjecutable
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
            this.btnTeclado = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.btnEjecutarCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(165, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTeclado
            // 
            this.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclado.Image = global::Controles.Properties.Resources.preferences_desktop_keyboard_4;
            this.btnTeclado.Location = new System.Drawing.Point(32, 194);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(235, 57);
            this.btnTeclado.TabIndex = 3;
            this.btnTeclado.Text = "Teclado";
            this.btnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeclado.UseVisualStyleBackColor = true;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            // 
            // btnExplorer
            // 
            this.btnExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorer.Image = global::Controles.Properties.Resources.world;
            this.btnExplorer.Location = new System.Drawing.Point(32, 108);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(235, 69);
            this.btnExplorer.TabIndex = 2;
            this.btnExplorer.Text = "&Internet Explorer";
            this.btnExplorer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // btnEjecutarCalculadora
            // 
            this.btnEjecutarCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutarCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarCalculadora.Image = global::Controles.Properties.Resources.calendar;
            this.btnEjecutarCalculadora.Location = new System.Drawing.Point(32, 32);
            this.btnEjecutarCalculadora.Name = "btnEjecutarCalculadora";
            this.btnEjecutarCalculadora.Size = new System.Drawing.Size(235, 70);
            this.btnEjecutarCalculadora.TabIndex = 1;
            this.btnEjecutarCalculadora.Text = "&Calculadora";
            this.btnEjecutarCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutarCalculadora.UseVisualStyleBackColor = true;
            this.btnEjecutarCalculadora.Click += new System.EventHandler(this.btnEjecutarCalculadora_Click);
            // 
            // frmEjecutable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 335);
            this.Controls.Add(this.btnTeclado);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.btnEjecutarCalculadora);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEjecutable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecutable";
            this.Load += new System.EventHandler(this.frmEjecutable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEjecutarCalculadora;
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.Button btnTeclado;
    }
}