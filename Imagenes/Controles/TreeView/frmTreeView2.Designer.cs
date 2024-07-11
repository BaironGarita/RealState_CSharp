namespace Controles
{
    partial class frmTreeView2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView2));
            this.trvBaseDatos = new System.Windows.Forms.TreeView();
            this.imgLstImagenes = new System.Windows.Forms.ImageList(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trvBaseDatos
            // 
            this.trvBaseDatos.ImageIndex = 0;
            this.trvBaseDatos.ImageList = this.imgLstImagenes;
            this.trvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.trvBaseDatos.Name = "trvBaseDatos";
            this.trvBaseDatos.SelectedImageIndex = 0;
            this.trvBaseDatos.Size = new System.Drawing.Size(309, 285);
            this.trvBaseDatos.TabIndex = 0;
            this.trvBaseDatos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvBaseDatos_AfterSelect_1);
            // 
            // imgLstImagenes
            // 
            this.imgLstImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstImagenes.ImageStream")));
            this.imgLstImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstImagenes.Images.SetKeyName(0, "bd.png");
            this.imgLstImagenes.Images.SetKeyName(1, "icon.png");
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(339, 264);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmTreeView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 309);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.trvBaseDatos);
            this.Name = "frmTreeView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView 2";
            this.Load += new System.EventHandler(this.frmTreeView2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvBaseDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imgLstImagenes;
    }
}