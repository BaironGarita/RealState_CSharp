namespace Controles
{
    partial class frmTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            this.btnSalir = new System.Windows.Forms.Button();
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.imglst = new System.Windows.Forms.ImageList(this.components);
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnBorrarNodo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(427, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // trvArbol
            // 
            this.trvArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvArbol.ImageIndex = 0;
            this.trvArbol.ImageList = this.imglst;
            this.trvArbol.Location = new System.Drawing.Point(12, 12);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.SelectedImageIndex = 0;
            this.trvArbol.Size = new System.Drawing.Size(409, 308);
            this.trvArbol.TabIndex = 1;
            this.trvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvArbol_AfterSelect);
            // 
            // imglst
            // 
            this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
            this.imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst.Images.SetKeyName(0, "featured.png");
            this.imglst.Images.SetKeyName(1, "networking.png");
            // 
            // btnLlenar
            // 
            this.btnLlenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenar.Location = new System.Drawing.Point(427, 12);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(101, 46);
            this.btnLlenar.TabIndex = 2;
            this.btnLlenar.Text = "&Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnBorrarNodo
            // 
            this.btnBorrarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNodo.Location = new System.Drawing.Point(427, 73);
            this.btnBorrarNodo.Name = "btnBorrarNodo";
            this.btnBorrarNodo.Size = new System.Drawing.Size(101, 46);
            this.btnBorrarNodo.TabIndex = 3;
            this.btnBorrarNodo.Text = "Borrar Nodo";
            this.btnBorrarNodo.UseVisualStyleBackColor = true;
            this.btnBorrarNodo.Click += new System.EventHandler(this.btnBorrarNodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(427, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 46);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Ver Nodos";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 332);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrarNodo);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.trvArbol);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnBorrarNodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ImageList imglst;
    }
}