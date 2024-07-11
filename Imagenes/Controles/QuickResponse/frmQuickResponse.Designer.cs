namespace Controles
{
    partial class frmQuickResponse
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagenQuickResponse = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnN = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnQuickResponse = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenQuickResponse)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtDato);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbImagenQuickResponse);
            this.splitContainer1.Size = new System.Drawing.Size(712, 393);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(61, 41);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(140, 20);
            this.txtDato.TabIndex = 1;
            this.txtDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDato_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // pbImagenQuickResponse
            // 
            this.pbImagenQuickResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagenQuickResponse.Location = new System.Drawing.Point(0, 0);
            this.pbImagenQuickResponse.Name = "pbImagenQuickResponse";
            this.pbImagenQuickResponse.Size = new System.Drawing.Size(408, 391);
            this.pbImagenQuickResponse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenQuickResponse.TabIndex = 0;
            this.pbImagenQuickResponse.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnN,
            this.toolStripBtnQuickResponse,
            this.toolStripBtnSalvar,
            this.toolStripBtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 54);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnN
            // 
            this.toolStripBtnN.Image = global::Controles.Properties.Resources.archives;
            this.toolStripBtnN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnN.Name = "toolStripBtnN";
            this.toolStripBtnN.Size = new System.Drawing.Size(46, 51);
            this.toolStripBtnN.Text = "Nuevo";
            this.toolStripBtnN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnN.ToolTipText = "Nuevo";
            this.toolStripBtnN.Click += new System.EventHandler(this.toolStripBtnN_Click);
            // 
            // toolStripBtnQuickResponse
            // 
            this.toolStripBtnQuickResponse.Image = global::Controles.Properties.Resources.collaboration;
            this.toolStripBtnQuickResponse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnQuickResponse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnQuickResponse.Name = "toolStripBtnQuickResponse";
            this.toolStripBtnQuickResponse.Size = new System.Drawing.Size(36, 51);
            this.toolStripBtnQuickResponse.Text = "QR";
            this.toolStripBtnQuickResponse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnQuickResponse.Click += new System.EventHandler(this.toolStripBtnQuickResponse_Click);
            // 
            // toolStripBtnSalvar
            // 
            this.toolStripBtnSalvar.Image = global::Controles.Properties.Resources.Writing;
            this.toolStripBtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalvar.Name = "toolStripBtnSalvar";
            this.toolStripBtnSalvar.Size = new System.Drawing.Size(42, 51);
            this.toolStripBtnSalvar.Text = "Salvar";
            this.toolStripBtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalvar.Click += new System.EventHandler(this.toolStripBtnSalvar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::Controles.Properties.Resources.sign_out;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(36, 51);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // frmQuickResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 447);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmQuickResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Response";
            this.Load += new System.EventHandler(this.frmQuickResponse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenQuickResponse)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagenQuickResponse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnN;
        private System.Windows.Forms.ToolStripButton toolStripBtnQuickResponse;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalvar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
    }
}