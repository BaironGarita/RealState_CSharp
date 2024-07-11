namespace Controles
{
    partial class frmTeclas
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
            this.pbiNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbiNave)).BeginInit();
            this.SuspendLayout();
            // 
            // pbiNave
            // 
            this.pbiNave.Image = global::Controles.Properties.Resources.turbo;
            this.pbiNave.InitialImage = global::Controles.Properties.Resources.naveNormal;
            this.pbiNave.Location = new System.Drawing.Point(283, 245);
            this.pbiNave.Name = "pbiNave";
            this.pbiNave.Size = new System.Drawing.Size(56, 53);
            this.pbiNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbiNave.TabIndex = 0;
            this.pbiNave.TabStop = false;
            // 
            // frmTeclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(580, 422);
            this.Controls.Add(this.pbiNave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTeclas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teclas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeclas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbiNave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbiNave;
    }
}