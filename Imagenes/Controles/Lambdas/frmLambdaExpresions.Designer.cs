namespace Controles
{
    partial class frmLambdaExpresions
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbExist = new System.Windows.Forms.RadioButton();
            this.txtExiste = new System.Windows.Forms.TextBox();
            this.rdbFind = new System.Windows.Forms.RadioButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rdbOrderBy = new System.Windows.Forms.RadioButton();
            this.rdbFindAll = new System.Windows.Forms.RadioButton();
            this.mskFindAll = new System.Windows.Forms.MaskedTextBox();
            this.rdbForEach = new System.Windows.Forms.RadioButton();
            this.linkbl = new System.Windows.Forms.LinkLabel();
            this.rdbMax = new System.Windows.Forms.RadioButton();
            this.rdbTake = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvRespuestas = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 469);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rdbExist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtExiste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbFind, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFind, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdbOrderBy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdbFindAll, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mskFindAll, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdbForEach, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkbl, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.rdbMax, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbTake, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnEjecutar, 2, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdbExist
            // 
            this.rdbExist.AutoSize = true;
            this.rdbExist.Checked = true;
            this.rdbExist.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExist.Location = new System.Drawing.Point(3, 3);
            this.rdbExist.Name = "rdbExist";
            this.rdbExist.Size = new System.Drawing.Size(962, 20);
            this.rdbExist.TabIndex = 1;
            this.rdbExist.TabStop = true;
            this.rdbExist.Text = "_ListaPersonas.Exists(a => a.Nombre.Equals(this.txtExiste.Text,StringComparison.I" +
    "nvariantCultureIgnoreCase) == true);";
            this.rdbExist.UseVisualStyleBackColor = true;
            // 
            // txtExiste
            // 
            this.txtExiste.Location = new System.Drawing.Point(971, 3);
            this.txtExiste.Name = "txtExiste";
            this.txtExiste.Size = new System.Drawing.Size(100, 20);
            this.txtExiste.TabIndex = 2;
            this.txtExiste.Text = "Barbara";
            // 
            // rdbFind
            // 
            this.rdbFind.AutoSize = true;
            this.rdbFind.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFind.Location = new System.Drawing.Point(3, 29);
            this.rdbFind.Name = "rdbFind";
            this.rdbFind.Size = new System.Drawing.Size(719, 21);
            this.rdbFind.TabIndex = 3;
            this.rdbFind.TabStop = true;
            this.rdbFind.Text = " Persona oPersona = _ListaPersonas.Find(h => h.Cedula == this.txtFind.Text );";
            this.rdbFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(971, 29);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 4;
            this.txtFind.Text = "456";
            // 
            // rdbOrderBy
            // 
            this.rdbOrderBy.AutoSize = true;
            this.rdbOrderBy.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOrderBy.Location = new System.Drawing.Point(3, 56);
            this.rdbOrderBy.Name = "rdbOrderBy";
            this.rdbOrderBy.Size = new System.Drawing.Size(611, 21);
            this.rdbOrderBy.TabIndex = 5;
            this.rdbOrderBy.TabStop = true;
            this.rdbOrderBy.Text = "_ListaPersonas = _ListaPersonas.OrderBy(f => f.Salario).ToList();";
            this.rdbOrderBy.UseVisualStyleBackColor = true;
            // 
            // rdbFindAll
            // 
            this.rdbFindAll.AutoSize = true;
            this.rdbFindAll.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFindAll.Location = new System.Drawing.Point(3, 83);
            this.rdbFindAll.Name = "rdbFindAll";
            this.rdbFindAll.Size = new System.Drawing.Size(845, 21);
            this.rdbFindAll.TabIndex = 7;
            this.rdbFindAll.TabStop = true;
            this.rdbFindAll.Text = "_ListaPersonas = _ListaPersonas.FindAll(p => p.Salario <= int.Parse(this.mskFindA" +
    "ll.Text));";
            this.rdbFindAll.UseVisualStyleBackColor = true;
            // 
            // mskFindAll
            // 
            this.mskFindAll.Location = new System.Drawing.Point(971, 83);
            this.mskFindAll.Mask = "999999";
            this.mskFindAll.Name = "mskFindAll";
            this.mskFindAll.Size = new System.Drawing.Size(100, 20);
            this.mskFindAll.TabIndex = 8;
            this.mskFindAll.Text = "30000";
            // 
            // rdbForEach
            // 
            this.rdbForEach.AutoSize = true;
            this.rdbForEach.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbForEach.Location = new System.Drawing.Point(3, 110);
            this.rdbForEach.Name = "rdbForEach";
            this.rdbForEach.Size = new System.Drawing.Size(548, 21);
            this.rdbForEach.TabIndex = 9;
            this.rdbForEach.TabStop = true;
            this.rdbForEach.Text = "_ListaPersonas.ForEach(s => s.Salario=  s.Salario * 1.10);";
            this.rdbForEach.UseVisualStyleBackColor = true;
            // 
            // linkbl
            // 
            this.linkbl.AutoSize = true;
            this.linkbl.Location = new System.Drawing.Point(3, 233);
            this.linkbl.Name = "linkbl";
            this.linkbl.Size = new System.Drawing.Size(305, 13);
            this.linkbl.TabIndex = 12;
            this.linkbl.TabStop = true;
            this.linkbl.Text = "https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b";
            this.linkbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkbl_LinkClicked);
            // 
            // rdbMax
            // 
            this.rdbMax.AutoSize = true;
            this.rdbMax.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMax.Location = new System.Drawing.Point(3, 137);
            this.rdbMax.Name = "rdbMax";
            this.rdbMax.Size = new System.Drawing.Size(494, 21);
            this.rdbMax.TabIndex = 10;
            this.rdbMax.TabStop = true;
            this.rdbMax.Text = "double @double = _ListaPersonas.Max(s => s.Salario);";
            this.rdbMax.UseVisualStyleBackColor = true;
            // 
            // rdbTake
            // 
            this.rdbTake.AutoSize = true;
            this.rdbTake.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTake.Location = new System.Drawing.Point(3, 164);
            this.rdbTake.Name = "rdbTake";
            this.rdbTake.Size = new System.Drawing.Size(494, 21);
            this.rdbTake.TabIndex = 13;
            this.rdbTake.TabStop = true;
            this.rdbTake.Text = "IEnumerable<Persona> lista = _ListaPersonas.Take(2);";
            this.rdbTake.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Controles.Properties.Resources.logout1;
            this.btnSalir.Location = new System.Drawing.Point(971, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Image = global::Controles.Properties.Resources.lambdaimagen;
            this.btnEjecutar.Location = new System.Drawing.Point(971, 191);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(100, 39);
            this.btnEjecutar.TabIndex = 6;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click_1);
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
            this.splitContainer2.Panel1.Controls.Add(this.dgvDatos);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvRespuestas);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(1098, 154);
            this.splitContainer2.SplitterDistance = 475;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(471, 125);
            this.dgvDatos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(471, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Datos Originales";
            // 
            // dgvRespuestas
            // 
            this.dgvRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRespuestas.Location = new System.Drawing.Point(0, 25);
            this.dgvRespuestas.Name = "dgvRespuestas";
            this.dgvRespuestas.Size = new System.Drawing.Size(615, 125);
            this.dgvRespuestas.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(615, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel2.Text = "Respuestas";
            // 
            // frmLambdaExpresions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 469);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLambdaExpresions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lambda Expresions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLambdaExpresions_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dgvRespuestas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdbExist;
        private System.Windows.Forms.TextBox txtExiste;
        private System.Windows.Forms.RadioButton rdbFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rdbOrderBy;
        private System.Windows.Forms.RadioButton rdbFindAll;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.MaskedTextBox mskFindAll;
        private System.Windows.Forms.RadioButton rdbForEach;
        private System.Windows.Forms.RadioButton rdbMax;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.LinkLabel linkbl;
        private System.Windows.Forms.RadioButton rdbTake;
    }
}