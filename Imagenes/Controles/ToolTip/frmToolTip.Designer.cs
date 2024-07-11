namespace Controles
{
    partial class frmToolTip
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblColegio = new System.Windows.Forms.Label();
            this.lblCEM = new System.Windows.Forms.Label();
            this.ttpMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnBorrarHistorico = new System.Windows.Forms.Button();
            this.ttpMensajeAlerta = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(227, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.ttpMensaje.SetToolTip(this.btnSalir, "Salir de la Aplicación !!!");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColegio.Location = new System.Drawing.Point(36, 28);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(244, 20);
            this.lblColegio.TabIndex = 1;
            this.lblColegio.Text = "Universidad Técnica Nacional";
            this.ttpMensaje.SetToolTip(this.lblColegio, "Universidad Técnica Nacional");
            // 
            // lblCEM
            // 
            this.lblCEM.AutoSize = true;
            this.lblCEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEM.Location = new System.Drawing.Point(137, 104);
            this.lblCEM.Name = "lblCEM";
            this.lblCEM.Size = new System.Drawing.Size(52, 18);
            this.lblCEM.TabIndex = 2;
            this.lblCEM.Text = "U.T.N";
            this.ttpMensaje.SetToolTip(this.lblCEM, "Ingeniería de Software");
            // 
            // ttpMensaje
            // 
            this.ttpMensaje.IsBalloon = true;
            this.ttpMensaje.ShowAlways = true;
            this.ttpMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpMensaje.ToolTipTitle = "Información";
            // 
            // btnBorrarHistorico
            // 
            this.btnBorrarHistorico.Location = new System.Drawing.Point(13, 199);
            this.btnBorrarHistorico.Name = "btnBorrarHistorico";
            this.btnBorrarHistorico.Size = new System.Drawing.Size(91, 42);
            this.btnBorrarHistorico.TabIndex = 3;
            this.btnBorrarHistorico.Text = "Borrar Histórico";
            this.ttpMensajeAlerta.SetToolTip(this.btnBorrarHistorico, "Advertencia: Se eliminará el Histórico permanentemente");
            this.btnBorrarHistorico.UseVisualStyleBackColor = true;
            // 
            // ttpMensajeAlerta
            // 
            this.ttpMensajeAlerta.BackColor = System.Drawing.Color.Red;
            this.ttpMensajeAlerta.IsBalloon = true;
            this.ttpMensajeAlerta.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpMensajeAlerta.ToolTipTitle = "Ojo ALERTA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // frmToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBorrarHistorico);
            this.Controls.Add(this.lblCEM);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmToolTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolTip";
            this.ttpMensaje.SetToolTip(this, "Mensaje");
            this.Load += new System.EventHandler(this.frmToolTip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblColegio;
        private System.Windows.Forms.Label lblCEM;
        private System.Windows.Forms.ToolTip ttpMensaje;
        private System.Windows.Forms.Button btnBorrarHistorico;
        private System.Windows.Forms.ToolTip ttpMensajeAlerta;
        private System.Windows.Forms.TextBox textBox1;
    }
}