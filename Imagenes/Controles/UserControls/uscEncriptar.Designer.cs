namespace Controles
{
    partial class uscEncriptar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTripleDES = new System.Windows.Forms.RadioButton();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbAES = new System.Windows.Forms.RadioButton();
            this.rdbRSA = new System.Windows.Forms.RadioButton();
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnEncriptar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDesencriptar = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.96407F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPalabra, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdbTripleDES, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRespuesta, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdbAES, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdbRSA, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.07421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.99647F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra a comprimir";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(110, 3);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(206, 22);
            this.txtPalabra.TabIndex = 1;
            this.txtPalabra.Text = "Universidad Tecnica Nacional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Algoritmos de Encriptación";
            // 
            // rdbTripleDES
            // 
            this.rdbTripleDES.AutoSize = true;
            this.rdbTripleDES.Checked = true;
            this.rdbTripleDES.Location = new System.Drawing.Point(110, 44);
            this.rdbTripleDES.Name = "rdbTripleDES";
            this.rdbTripleDES.Size = new System.Drawing.Size(89, 20);
            this.rdbTripleDES.TabIndex = 3;
            this.rdbTripleDES.TabStop = true;
            this.rdbTripleDES.Text = "TripleDES";
            this.rdbTripleDES.UseVisualStyleBackColor = true;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(110, 150);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRespuesta.Size = new System.Drawing.Size(206, 121);
            this.txtRespuesta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Palabra compresa";
            // 
            // rdbAES
            // 
            this.rdbAES.AutoSize = true;
            this.rdbAES.Location = new System.Drawing.Point(110, 81);
            this.rdbAES.Name = "rdbAES";
            this.rdbAES.Size = new System.Drawing.Size(53, 20);
            this.rdbAES.TabIndex = 4;
            this.rdbAES.Text = "AES";
            this.rdbAES.UseVisualStyleBackColor = true;
            // 
            // rdbRSA
            // 
            this.rdbRSA.AutoSize = true;
            this.rdbRSA.Location = new System.Drawing.Point(110, 116);
            this.rdbRSA.Name = "rdbRSA";
            this.rdbRSA.Size = new System.Drawing.Size(54, 20);
            this.rdbRSA.TabIndex = 9;
            this.rdbRSA.TabStop = true;
            this.rdbRSA.Text = "RSA";
            this.rdbRSA.UseVisualStyleBackColor = true;
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.AutoSize = false;
            this.tspPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.tspPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEncriptar,
            this.toolStripBtnSalir,
            this.toolStripBtnDesencriptar});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(120, 412);
            this.tspPrincipal.TabIndex = 1;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // toolStripBtnEncriptar
            // 
            this.toolStripBtnEncriptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnEncriptar.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnEncriptar.Image = global::Controles.Properties.Resources.process;
            this.toolStripBtnEncriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnEncriptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEncriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEncriptar.Name = "toolStripBtnEncriptar";
            this.toolStripBtnEncriptar.Size = new System.Drawing.Size(118, 36);
            this.toolStripBtnEncriptar.Text = "Encriptar";
            this.toolStripBtnEncriptar.Click += new System.EventHandler(this.toolStripBtnEncriptar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSalir.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnSalir.Image = global::Controles.Properties.Resources.sign_out1;
            this.toolStripBtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(108, 36);
            this.toolStripBtnSalir.Text = "Volver";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // toolStripBtnDesencriptar
            // 
            this.toolStripBtnDesencriptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnDesencriptar.Image = global::Controles.Properties.Resources.communication;
            this.toolStripBtnDesencriptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnDesencriptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDesencriptar.Name = "toolStripBtnDesencriptar";
            this.toolStripBtnDesencriptar.Size = new System.Drawing.Size(118, 36);
            this.toolStripBtnDesencriptar.Text = "Desencriptar";
            this.toolStripBtnDesencriptar.Click += new System.EventHandler(this.toolStripBtnDescomprimir_Click);
            // 
            // uscEncriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tspPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uscEncriptar";
            this.Size = new System.Drawing.Size(717, 412);
            this.Load += new System.EventHandler(this.uscEncriptar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTripleDES;
        private System.Windows.Forms.RadioButton rdbAES;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbRSA;
        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnEncriptar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.ToolStripButton toolStripBtnDesencriptar;
    }
}
