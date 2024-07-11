namespace Controles
{
    partial class frmJSON
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
            this.rtbJSON = new System.Windows.Forms.RichTextBox();
            this.lblJsonMensaje = new System.Windows.Forms.Label();
            this.dgvJSON = new System.Windows.Forms.DataGridView();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.toolStripBtnConvertirJSON_A_List = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnListObject_a_JSON = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJSON)).BeginInit();
            this.toolStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbJSON
            // 
            this.rtbJSON.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbJSON.Location = new System.Drawing.Point(12, 68);
            this.rtbJSON.Name = "rtbJSON";
            this.rtbJSON.Size = new System.Drawing.Size(679, 140);
            this.rtbJSON.TabIndex = 1;
            this.rtbJSON.Text = "[\n     { \"NoDeposito\": 123, \"Descripcion\": \"Recibo de Agua\",\"Fecha\": \"01-01-2020\"" +
    " },\n     { \"NoDeposito\": 555, \"Descripcion\": \"Recibo de luz\" ,\"Fecha\": \"01-06-20" +
    "20\" }\n ]";
            // 
            // lblJsonMensaje
            // 
            this.lblJsonMensaje.AutoSize = true;
            this.lblJsonMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJsonMensaje.Location = new System.Drawing.Point(12, 45);
            this.lblJsonMensaje.Name = "lblJsonMensaje";
            this.lblJsonMensaje.Size = new System.Drawing.Size(55, 20);
            this.lblJsonMensaje.TabIndex = 3;
            this.lblJsonMensaje.Text = "JSON";
            // 
            // dgvJSON
            // 
            this.dgvJSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJSON.Location = new System.Drawing.Point(12, 234);
            this.dgvJSON.Name = "dgvJSON";
            this.dgvJSON.Size = new System.Drawing.Size(679, 160);
            this.dgvJSON.TabIndex = 4;
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnConvertirJSON_A_List,
            this.toolStripBtnListObject_a_JSON,
            this.toolStripBtnSalir});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(708, 39);
            this.toolStripPrincipal.TabIndex = 5;
            this.toolStripPrincipal.Text = "toolStrip1";
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetos.Location = new System.Drawing.Point(12, 211);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(115, 20);
            this.lblObjetos.TabIndex = 6;
            this.lblObjetos.Text = "Lista Objetos";
            // 
            // toolStripBtnConvertirJSON_A_List
            // 
            this.toolStripBtnConvertirJSON_A_List.Image = global::Controles.Properties.Resources.archives;
            this.toolStripBtnConvertirJSON_A_List.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnConvertirJSON_A_List.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnConvertirJSON_A_List.Name = "toolStripBtnConvertirJSON_A_List";
            this.toolStripBtnConvertirJSON_A_List.Size = new System.Drawing.Size(195, 36);
            this.toolStripBtnConvertirJSON_A_List.Text = "Convetir JSON a LIST Objects";
            this.toolStripBtnConvertirJSON_A_List.Click += new System.EventHandler(this.toolStripBtnConvertirJSON_A_List_Click);
            // 
            // toolStripBtnListObject_a_JSON
            // 
            this.toolStripBtnListObject_a_JSON.Image = global::Controles.Properties.Resources.document_library;
            this.toolStripBtnListObject_a_JSON.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnListObject_a_JSON.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnListObject_a_JSON.Name = "toolStripBtnListObject_a_JSON";
            this.toolStripBtnListObject_a_JSON.Size = new System.Drawing.Size(196, 36);
            this.toolStripBtnListObject_a_JSON.Text = "Convertir List Objects a JSON";
            this.toolStripBtnListObject_a_JSON.Click += new System.EventHandler(this.toolStripBtnListObject_a_JSON_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::Controles.Properties.Resources.logout2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(65, 36);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // frmJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 406);
            this.Controls.Add(this.lblObjetos);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.dgvJSON);
            this.Controls.Add(this.lblJsonMensaje);
            this.Controls.Add(this.rtbJSON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmJSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON";
            this.Load += new System.EventHandler(this.frmJSON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJSON)).EndInit();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbJSON;
        private System.Windows.Forms.Label lblJsonMensaje;
        private System.Windows.Forms.DataGridView dgvJSON;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnConvertirJSON_A_List;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.ToolStripButton toolStripBtnListObject_a_JSON;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
    }
}