namespace Controles
{
    partial class frmObserver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObserver));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsvUsuario1 = new System.Windows.Forms.ListView();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lsvEnviarMensajeUTN = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkVilma = new System.Windows.Forms.CheckBox();
            this.chkPablo = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lsvUsuario2 = new System.Windows.Forms.ListView();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(701, 501);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(701, 229);
            this.splitContainer3.SplitterDistance = 408;
            this.splitContainer3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Controles.Properties.Resources.caralibro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lsvUsuario1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 222);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario Vilma";
            // 
            // lsvUsuario1
            // 
            this.lsvUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvUsuario1.ForeColor = System.Drawing.Color.Blue;
            this.lsvUsuario1.HideSelection = false;
            this.lsvUsuario1.LargeImageList = this.imgLista;
            this.lsvUsuario1.Location = new System.Drawing.Point(3, 25);
            this.lsvUsuario1.Name = "lsvUsuario1";
            this.lsvUsuario1.Size = new System.Drawing.Size(251, 194);
            this.lsvUsuario1.SmallImageList = this.imgLista;
            this.lsvUsuario1.TabIndex = 0;
            this.ttpMensaje.SetToolTip(this.lsvUsuario1, "Vilma Picapiedra");
            this.lsvUsuario1.UseCompatibleStateImageBehavior = false;
            this.lsvUsuario1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imgLista
            // 
            this.imgLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLista.ImageStream")));
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLista.Images.SetKeyName(0, "Mail.png");
            this.imgLista.Images.SetKeyName(1, "Mail alt.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Size = new System.Drawing.Size(701, 268);
            this.splitContainer2.SplitterDistance = 407;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario UTN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controles.Properties.Resources.UTN;
            this.pictureBox2.Location = new System.Drawing.Point(151, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMensaje);
            this.groupBox2.Controls.Add(this.lsvEnviarMensajeUTN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Publicaci/n en Muro";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(6, 24);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(203, 26);
            this.txtMensaje.TabIndex = 1;
            this.ttpMensaje.SetToolTip(this.txtMensaje, "Ingrese el mensaje que desea");
            this.txtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensaje_KeyDown);
            // 
            // lsvEnviarMensajeUTN
            // 
            this.lsvEnviarMensajeUTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEnviarMensajeUTN.HideSelection = false;
            this.lsvEnviarMensajeUTN.Location = new System.Drawing.Point(6, 56);
            this.lsvEnviarMensajeUTN.Name = "lsvEnviarMensajeUTN";
            this.lsvEnviarMensajeUTN.Size = new System.Drawing.Size(233, 107);
            this.lsvEnviarMensajeUTN.SmallImageList = this.imgLista;
            this.lsvEnviarMensajeUTN.TabIndex = 0;
            this.ttpMensaje.SetToolTip(this.lsvEnviarMensajeUTN, "Publicacion en el muro");
            this.lsvEnviarMensajeUTN.UseCompatibleStateImageBehavior = false;
            this.lsvEnviarMensajeUTN.View = System.Windows.Forms.View.SmallIcon;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkVilma);
            this.groupBox3.Controls.Add(this.chkPablo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(250, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 254);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amigos";
            // 
            // chkVilma
            // 
            this.chkVilma.AutoSize = true;
            this.chkVilma.Checked = true;
            this.chkVilma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVilma.Location = new System.Drawing.Point(9, 37);
            this.chkVilma.Name = "chkVilma";
            this.chkVilma.Size = new System.Drawing.Size(145, 24);
            this.chkVilma.TabIndex = 5;
            this.chkVilma.Text = "Vilma Picapiedra";
            this.chkVilma.UseVisualStyleBackColor = true;
            this.chkVilma.CheckedChanged += new System.EventHandler(this.chkVilma_CheckedChanged);
            // 
            // chkPablo
            // 
            this.chkPablo.AutoSize = true;
            this.chkPablo.Checked = true;
            this.chkPablo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPablo.Location = new System.Drawing.Point(9, 67);
            this.chkPablo.Name = "chkPablo";
            this.chkPablo.Size = new System.Drawing.Size(124, 24);
            this.chkPablo.TabIndex = 6;
            this.chkPablo.Text = "Pablo Marmol";
            this.chkPablo.UseVisualStyleBackColor = true;
            this.chkPablo.CheckedChanged += new System.EventHandler(this.chkPablo_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lsvUsuario2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(19, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 254);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuario Pablo";
            // 
            // lsvUsuario2
            // 
            this.lsvUsuario2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvUsuario2.ForeColor = System.Drawing.Color.Orange;
            this.lsvUsuario2.HideSelection = false;
            this.lsvUsuario2.LargeImageList = this.imgLista;
            this.lsvUsuario2.Location = new System.Drawing.Point(3, 22);
            this.lsvUsuario2.Name = "lsvUsuario2";
            this.lsvUsuario2.Size = new System.Drawing.Size(248, 229);
            this.lsvUsuario2.SmallImageList = this.imgLista;
            this.lsvUsuario2.TabIndex = 0;
            this.ttpMensaje.SetToolTip(this.lsvUsuario2, "Pablo Marmol");
            this.lsvUsuario2.UseCompatibleStateImageBehavior = false;
            this.lsvUsuario2.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ttpMensaje
            // 
            this.ttpMensaje.IsBalloon = true;
            this.ttpMensaje.ShowAlways = true;
            // 
            // frmObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 501);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmObserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observer";
            this.Load += new System.EventHandler(this.frmObserver_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ListView lsvEnviarMensajeUTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPablo;
        private System.Windows.Forms.CheckBox chkVilma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip ttpMensaje;
        public System.Windows.Forms.ListView lsvUsuario1;
        public System.Windows.Forms.ListView lsvUsuario2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ImageList imgLista;
    }
}