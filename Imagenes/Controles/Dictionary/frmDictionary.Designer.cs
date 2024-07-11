namespace Controles
{
    partial class frmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvCancionesDisponibles = new System.Windows.Forms.ListView();
            this.lstIpodCanciones = new System.Windows.Forms.ListBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(323, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 52);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Controles.Properties.Resources.Ipod;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lsvCancionesDisponibles);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(435, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 523);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canciones para arrastrar al Ipod";
            // 
            // lsvCancionesDisponibles
            // 
            this.lsvCancionesDisponibles.AllowDrop = true;
            this.lsvCancionesDisponibles.AutoArrange = false;
            this.lsvCancionesDisponibles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsvCancionesDisponibles.LargeImageList = this.imageList;
            this.lsvCancionesDisponibles.Location = new System.Drawing.Point(17, 21);
            this.lsvCancionesDisponibles.MultiSelect = false;
            this.lsvCancionesDisponibles.Name = "lsvCancionesDisponibles";
            this.lsvCancionesDisponibles.Size = new System.Drawing.Size(443, 398);
            this.lsvCancionesDisponibles.SmallImageList = this.imageList;
            this.lsvCancionesDisponibles.TabIndex = 1;
            this.lsvCancionesDisponibles.UseCompatibleStateImageBehavior = false;
            this.lsvCancionesDisponibles.View = System.Windows.Forms.View.Tile;
            this.lsvCancionesDisponibles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lsvCancionesDisponibles_ItemDrag);
            // 
            // lstIpodCanciones
            // 
            this.lstIpodCanciones.AllowDrop = true;
            this.lstIpodCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIpodCanciones.FormattingEnabled = true;
            this.lstIpodCanciones.Location = new System.Drawing.Point(55, 50);
            this.lstIpodCanciones.Name = "lstIpodCanciones";
            this.lstIpodCanciones.Size = new System.Drawing.Size(333, 186);
            this.lstIpodCanciones.TabIndex = 3;
            this.lstIpodCanciones.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstIpodCanciones_DragDrop);
            this.lstIpodCanciones.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstIpodCanciones_DragEnter);
            this.lstIpodCanciones.Click += new System.EventHandler(this.lstIpodCanciones_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "itunesmusic.jpg");
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(897, 545);
            this.Controls.Add(this.lstIpodCanciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.frmDictionary_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDictionary_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvCancionesDisponibles;
        private System.Windows.Forms.ListBox lstIpodCanciones;
        private System.Windows.Forms.ImageList imageList;
    }
}