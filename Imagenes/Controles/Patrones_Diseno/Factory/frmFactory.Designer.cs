namespace Controles
{
    partial class frmFactory
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
            this.btnPepperoni = new System.Windows.Forms.Button();
            this.btnPizzaQueso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rtbDetalle = new System.Windows.Forms.RichTextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPepperoni
            // 
            this.btnPepperoni.BackgroundImage = global::Controles.Properties.Resources.pepperoni_pizza;
            this.btnPepperoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPepperoni.Location = new System.Drawing.Point(12, 263);
            this.btnPepperoni.Name = "btnPepperoni";
            this.btnPepperoni.Size = new System.Drawing.Size(312, 227);
            this.btnPepperoni.TabIndex = 1;
            this.btnPepperoni.Text = "Pizza Pepperoni";
            this.btnPepperoni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPepperoni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnPepperoni, "Pizza de Pepperoni");
            this.btnPepperoni.UseVisualStyleBackColor = true;
            this.btnPepperoni.Click += new System.EventHandler(this.btnPepperoni_Click);
            // 
            // btnPizzaQueso
            // 
            this.btnPizzaQueso.BackgroundImage = global::Controles.Properties.Resources.pizza_quesos;
            this.btnPizzaQueso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizzaQueso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaQueso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPizzaQueso.Location = new System.Drawing.Point(12, 37);
            this.btnPizzaQueso.Name = "btnPizzaQueso";
            this.btnPizzaQueso.Size = new System.Drawing.Size(312, 220);
            this.btnPizzaQueso.TabIndex = 0;
            this.btnPizzaQueso.Text = "Pizza de Queso";
            this.btnPizzaQueso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPizzaQueso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnPizzaQueso, "Pizza de Queso !!!");
            this.btnPizzaQueso.UseVisualStyleBackColor = true;
            this.btnPizzaQueso.Click += new System.EventHandler(this.btnPizzaQueso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(526, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(24, 9);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(279, 20);
            this.lblEtiqueta.TabIndex = 3;
            this.lblEtiqueta.Text = "Escoja el tipo de Pizza que desee";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // rtbDetalle
            // 
            this.rtbDetalle.BackColor = System.Drawing.Color.Gainsboro;
            this.rtbDetalle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetalle.Location = new System.Drawing.Point(339, 37);
            this.rtbDetalle.Name = "rtbDetalle";
            this.rtbDetalle.ReadOnly = true;
            this.rtbDetalle.Size = new System.Drawing.Size(326, 379);
            this.rtbDetalle.TabIndex = 4;
            this.rtbDetalle.Text = "";
            this.toolTip1.SetToolTip(this.rtbDetalle, "Detalle de la Pizza");
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(436, 12);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(158, 20);
            this.lblDetalle.TabIndex = 5;
            this.lblDetalle.Text = "Detalle de la Pizza";
            // 
            // frmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 503);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.rtbDetalle);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPepperoni);
            this.Controls.Add(this.btnPizzaQueso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory";
            this.Load += new System.EventHandler(this.frmFactory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPizzaQueso;
        private System.Windows.Forms.Button btnPepperoni;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox rtbDetalle;
        private System.Windows.Forms.Label lblDetalle;
    }
}