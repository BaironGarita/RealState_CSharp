namespace Controles
{
    partial class frmAbstractFactory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkAmerica = new System.Windows.Forms.CheckBox();
            this.chkAfrica = new System.Windows.Forms.CheckBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbBison = new System.Windows.Forms.PictureBox();
            this.pbLeo = new System.Windows.Forms.PictureBox();
            this.pbWildebeest = new System.Windows.Forms.PictureBox();
            this.pbLobo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWildebeest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLobo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkAmerica);
            this.groupBox1.Controls.Add(this.chkAfrica);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Continentes";
            // 
            // ChkAmerica
            // 
            this.ChkAmerica.AutoSize = true;
            this.ChkAmerica.Location = new System.Drawing.Point(84, 25);
            this.ChkAmerica.Name = "ChkAmerica";
            this.ChkAmerica.Size = new System.Drawing.Size(78, 19);
            this.ChkAmerica.TabIndex = 1;
            this.ChkAmerica.Text = "América";
            this.ChkAmerica.UseVisualStyleBackColor = true;
            // 
            // chkAfrica
            // 
            this.chkAfrica.AutoSize = true;
            this.chkAfrica.Location = new System.Drawing.Point(19, 25);
            this.chkAfrica.Name = "chkAfrica";
            this.chkAfrica.Size = new System.Drawing.Size(62, 19);
            this.chkAfrica.TabIndex = 0;
            this.chkAfrica.Text = "Africa";
            this.chkAfrica.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(301, 309);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(218, 52);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ver Cadena Alimenticia";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(522, 309);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 52);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbBison
            // 
            this.pbBison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBison.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBison.Image = global::Controles.Properties.Resources.bison;
            this.pbBison.Location = new System.Drawing.Point(3, 70);
            this.pbBison.Name = "pbBison";
            this.pbBison.Size = new System.Drawing.Size(184, 235);
            this.pbBison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBison.TabIndex = 3;
            this.pbBison.TabStop = false;
            // 
            // pbLeo
            // 
            this.pbLeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLeo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLeo.Image = global::Controles.Properties.Resources.leon;
            this.pbLeo.Location = new System.Drawing.Point(188, 70);
            this.pbLeo.Name = "pbLeo";
            this.pbLeo.Size = new System.Drawing.Size(184, 235);
            this.pbLeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeo.TabIndex = 4;
            this.pbLeo.TabStop = false;
            // 
            // pbWildebeest
            // 
            this.pbWildebeest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWildebeest.Image = global::Controles.Properties.Resources.wildebeest;
            this.pbWildebeest.Location = new System.Drawing.Point(373, 70);
            this.pbWildebeest.Name = "pbWildebeest";
            this.pbWildebeest.Size = new System.Drawing.Size(184, 235);
            this.pbWildebeest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWildebeest.TabIndex = 5;
            this.pbWildebeest.TabStop = false;
            // 
            // pbLobo
            // 
            this.pbLobo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLobo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLobo.Image = global::Controles.Properties.Resources.wolf;
            this.pbLobo.Location = new System.Drawing.Point(558, 70);
            this.pbLobo.Name = "pbLobo";
            this.pbLobo.Size = new System.Drawing.Size(184, 235);
            this.pbLobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLobo.TabIndex = 6;
            this.pbLobo.TabStop = false;
            // 
            // frmAbstractFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 365);
            this.Controls.Add(this.pbLobo);
            this.Controls.Add(this.pbWildebeest);
            this.Controls.Add(this.pbLeo);
            this.Controls.Add(this.pbBison);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbstractFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abstract Factory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWildebeest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLobo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkAmerica;
        private System.Windows.Forms.CheckBox chkAfrica;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbBison;
        private System.Windows.Forms.PictureBox pbLeo;
        private System.Windows.Forms.PictureBox pbWildebeest;
        private System.Windows.Forms.PictureBox pbLobo;
    }
}