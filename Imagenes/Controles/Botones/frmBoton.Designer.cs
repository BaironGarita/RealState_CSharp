namespace Controles
{
    partial class frmBoton
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
            this.btnBoton2 = new System.Windows.Forms.Button();
            this.btnBoton3 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOtroBoton = new System.Windows.Forms.Button();
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton2
            // 
            this.btnBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBoton2.Location = new System.Drawing.Point(212, 29);
            this.btnBoton2.Name = "btnBoton2";
            this.btnBoton2.Size = new System.Drawing.Size(149, 91);
            this.btnBoton2.TabIndex = 1;
            this.btnBoton2.Text = "Flatstyle Flat";
            this.btnBoton2.UseVisualStyleBackColor = true;
            this.btnBoton2.Click += new System.EventHandler(this.btnBoton2_Click);
            // 
            // btnBoton3
            // 
            this.btnBoton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton3.Location = new System.Drawing.Point(38, 139);
            this.btnBoton3.Name = "btnBoton3";
            this.btnBoton3.Size = new System.Drawing.Size(149, 91);
            this.btnBoton3.TabIndex = 2;
            this.btnBoton3.Text = "Flatstyle Popup";
            this.btnBoton3.UseVisualStyleBackColor = true;
            this.btnBoton3.Click += new System.EventHandler(this.btnBoton3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(385, 139);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 91);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOtroBoton
            // 
            this.btnOtroBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtroBoton.Location = new System.Drawing.Point(212, 139);
            this.btnOtroBoton.Name = "btnOtroBoton";
            this.btnOtroBoton.Size = new System.Drawing.Size(149, 91);
            this.btnOtroBoton.TabIndex = 4;
            this.btnOtroBoton.Text = "Encuesta";
            this.btnOtroBoton.UseVisualStyleBackColor = true;
            this.btnOtroBoton.Click += new System.EventHandler(this.btnOtroBoton_Click);
            // 
            // btnBoton1
            // 
            this.btnBoton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton1.Image = global::Controles.Properties.Resources.configure;
            this.btnBoton1.Location = new System.Drawing.Point(38, 29);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(149, 91);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Standard";
            this.btnBoton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoton1.UseVisualStyleBackColor = true;
            this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
            // 
            // frmBoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.btnOtroBoton);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBoton3);
            this.Controls.Add(this.btnBoton2);
            this.Controls.Add(this.btnBoton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBoton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boton";
            this.Load += new System.EventHandler(this.frmBoton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Button btnBoton2;
        private System.Windows.Forms.Button btnBoton3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOtroBoton;
    }
}