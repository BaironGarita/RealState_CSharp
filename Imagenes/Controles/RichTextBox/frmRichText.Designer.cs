namespace Controles
{
    partial class frmRichText
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
            this.txttexto = new System.Windows.Forms.TextBox();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nUDSpin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSpin)).BeginInit();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttexto.Location = new System.Drawing.Point(12, 38);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(236, 24);
            this.txttexto.TabIndex = 0;
            this.txttexto.TextChanged += new System.EventHandler(this.txttexto_TextChanged);
            this.txttexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttexto_KeyPress);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(12, 64);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.ShowSelectionMargin = true;
            this.rtbTexto.Size = new System.Drawing.Size(236, 171);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digitar  Texto y dar enter";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(254, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 53);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir\r\n";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nUDSpin
            // 
            this.nUDSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDSpin.Location = new System.Drawing.Point(267, 39);
            this.nUDSpin.Name = "nUDSpin";
            this.nUDSpin.Size = new System.Drawing.Size(44, 24);
            this.nUDSpin.TabIndex = 5;
            this.nUDSpin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDSpin.ValueChanged += new System.EventHandler(this.nUDSpin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zoom";
            // 
            // frmRichText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDSpin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.txttexto);
            this.Name = "frmRichText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RichText";
            ((System.ComponentModel.ISupportInitialize)(this.nUDSpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nUDSpin;
        private System.Windows.Forms.Label label2;
    }
}