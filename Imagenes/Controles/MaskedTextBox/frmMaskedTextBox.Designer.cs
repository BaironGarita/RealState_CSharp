namespace Controles
{
    partial class frmMaskedTextBox
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
            this.mskPasswordChar = new System.Windows.Forms.MaskedTextBox();
            this.lblPasswordChar = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.mskMask = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mskMask2 = new System.Windows.Forms.MaskedTextBox();
            this.lblMask2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskPasswordChar
            // 
            this.mskPasswordChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPasswordChar.Location = new System.Drawing.Point(135, 29);
            this.mskPasswordChar.Name = "mskPasswordChar";
            this.mskPasswordChar.PasswordChar = '*';
            this.mskPasswordChar.Size = new System.Drawing.Size(154, 24);
            this.mskPasswordChar.TabIndex = 0;
            this.mskPasswordChar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskPasswordChar_MaskInputRejected);
            // 
            // lblPasswordChar
            // 
            this.lblPasswordChar.AutoSize = true;
            this.lblPasswordChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordChar.Location = new System.Drawing.Point(14, 32);
            this.lblPasswordChar.Name = "lblPasswordChar";
            this.lblPasswordChar.Size = new System.Drawing.Size(107, 18);
            this.lblPasswordChar.TabIndex = 1;
            this.lblPasswordChar.Text = "PasswordChar";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask.Location = new System.Drawing.Point(14, 69);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(113, 18);
            this.lblMask.TabIndex = 2;
            this.lblMask.Text = "Mask DateTime";
            // 
            // mskMask
            // 
            this.mskMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMask.Location = new System.Drawing.Point(135, 66);
            this.mskMask.Mask = "00/00/0000 00:00";
            this.mskMask.Name = "mskMask";
            this.mskMask.Size = new System.Drawing.Size(154, 24);
            this.mskMask.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(304, 73);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 55);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mskMask2
            // 
            this.mskMask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMask2.Location = new System.Drawing.Point(135, 104);
            this.mskMask2.Mask = "99999";
            this.mskMask2.Name = "mskMask2";
            this.mskMask2.Size = new System.Drawing.Size(154, 24);
            this.mskMask2.TabIndex = 2;
            this.mskMask2.ValidatingType = typeof(int);
            // 
            // lblMask2
            // 
            this.lblMask2.AutoSize = true;
            this.lblMask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask2.Location = new System.Drawing.Point(14, 104);
            this.lblMask2.Name = "lblMask2";
            this.lblMask2.Size = new System.Drawing.Size(111, 18);
            this.lblMask2.TabIndex = 6;
            this.lblMask2.Text = "Mask Números";
            // 
            // frmMaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 146);
            this.Controls.Add(this.lblMask2);
            this.Controls.Add(this.mskMask2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mskMask);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblPasswordChar);
            this.Controls.Add(this.mskPasswordChar);
            this.Name = "frmMaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskPasswordChar;
        private System.Windows.Forms.Label lblPasswordChar;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.MaskedTextBox mskMask;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mskMask2;
        private System.Windows.Forms.Label lblMask2;
    }
}