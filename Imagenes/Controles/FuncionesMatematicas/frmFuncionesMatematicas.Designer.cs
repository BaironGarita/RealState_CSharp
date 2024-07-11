namespace Controles
{
    partial class frmFuncionesMatematicas
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnSenoLineal = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagen.Location = new System.Drawing.Point(12, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(562, 420);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            this.pbImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImagen_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(695, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(602, 29);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(202, 69);
            this.btnSeno.TabIndex = 2;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnSenoLineal
            // 
            this.btnSenoLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenoLineal.Location = new System.Drawing.Point(602, 264);
            this.btnSenoLineal.Name = "btnSenoLineal";
            this.btnSenoLineal.Size = new System.Drawing.Size(202, 69);
            this.btnSenoLineal.TabIndex = 3;
            this.btnSenoLineal.Text = "Seno Lineal";
            this.btnSenoLineal.UseVisualStyleBackColor = true;
            this.btnSenoLineal.Click += new System.EventHandler(this.btnSenoLineal_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParabola.Location = new System.Drawing.Point(602, 179);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(202, 69);
            this.btnParabola.TabIndex = 4;
            this.btnParabola.Text = "Parábola";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoseno.Location = new System.Drawing.Point(602, 104);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(202, 70);
            this.btnCoseno.TabIndex = 5;
            this.btnCoseno.Text = "Coseno";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // frmFuncionesMatematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 444);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnParabola);
            this.Controls.Add(this.btnSenoLineal);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmFuncionesMatematicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funciones Matemáticas";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnSenoLineal;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.Button btnCoseno;
    }
}