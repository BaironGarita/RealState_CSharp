namespace Controles
{
    partial class uscComprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscComprimir));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnComprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDescomprimir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.tspPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.AutoSize = false;
            this.tspPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.tspPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnComprimir,
            this.toolStripBtnSalir,
            this.toolStripBtnDescomprimir});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(126, 402);
            this.tspPrincipal.TabIndex = 2;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // toolStripBtnComprimir
            // 
            this.toolStripBtnComprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnComprimir.ForeColor = System.Drawing.Color.Black;
            this.toolStripBtnComprimir.Image = global::Controles.Properties.Resources.feed1;
            this.toolStripBtnComprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnComprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnComprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnComprimir.Name = "toolStripBtnComprimir";
            this.toolStripBtnComprimir.Size = new System.Drawing.Size(124, 36);
            this.toolStripBtnComprimir.Text = "Comprimir";
            this.toolStripBtnComprimir.Click += new System.EventHandler(this.toolStripBtnComprimir_Click);
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
            this.toolStripBtnSalir.Size = new System.Drawing.Size(114, 36);
            this.toolStripBtnSalir.Text = "Volver";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // toolStripBtnDescomprimir
            // 
            this.toolStripBtnDescomprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnDescomprimir.Image = global::Controles.Properties.Resources.limited_edition;
            this.toolStripBtnDescomprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnDescomprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDescomprimir.Name = "toolStripBtnDescomprimir";
            this.toolStripBtnDescomprimir.Size = new System.Drawing.Size(124, 36);
            this.toolStripBtnDescomprimir.Text = "Descomprimir";
            this.toolStripBtnDescomprimir.Click += new System.EventHandler(this.toolStripBtnDescomprimir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.38686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.61314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDatos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRespuesta, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(186, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.80153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.19847F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 262);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos a Comprimir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos Compresos en Base64";
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(152, 3);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDatos.Size = new System.Drawing.Size(211, 113);
            this.txtDatos.TabIndex = 2;
            this.txtDatos.Text = resources.GetString("txtDatos.Text");
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(152, 123);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRespuesta.Size = new System.Drawing.Size(211, 119);
            this.txtRespuesta.TabIndex = 3;
            // 
            // uscComprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tspPrincipal);
            this.Name = "uscComprimir";
            this.Size = new System.Drawing.Size(722, 402);
            this.Load += new System.EventHandler(this.uscComprimir_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnComprimir;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.ToolStripButton toolStripBtnDescomprimir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}
