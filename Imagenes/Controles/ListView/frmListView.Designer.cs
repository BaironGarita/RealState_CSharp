namespace Controles
{
    partial class frmListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.chkCheckbox = new System.Windows.Forms.CheckBox();
            this.lvwListview = new System.Windows.Forms.ListView();
            this.imglst = new System.Windows.Forms.ImageList(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdbDetails = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdList = new System.Windows.Forms.RadioButton();
            this.rdTile = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Valor3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkCheckbox
            // 
            this.chkCheckbox.AutoSize = true;
            this.chkCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckbox.Location = new System.Drawing.Point(360, 30);
            this.chkCheckbox.Name = "chkCheckbox";
            this.chkCheckbox.Size = new System.Drawing.Size(112, 22);
            this.chkCheckbox.TabIndex = 3;
            this.chkCheckbox.Text = "CheckBoxes";
            this.chkCheckbox.UseVisualStyleBackColor = true;
            this.chkCheckbox.CheckedChanged += new System.EventHandler(this.chkCheckbox_CheckedChanged);
            // 
            // lvwListview
            // 
            this.lvwListview.AllowDrop = true;
            this.lvwListview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListview.LargeImageList = this.imglst;
            this.lvwListview.Location = new System.Drawing.Point(12, 29);
            this.lvwListview.Name = "lvwListview";
            this.lvwListview.Size = new System.Drawing.Size(327, 193);
            this.lvwListview.SmallImageList = this.imglst;
            this.lvwListview.TabIndex = 4;
            this.lvwListview.UseCompatibleStateImageBehavior = false;
            this.lvwListview.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstListview_ItemChecked);
            this.lvwListview.Click += new System.EventHandler(this.lstListview_Click);
            // 
            // imglst
            // 
            this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
            this.imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst.Images.SetKeyName(0, "Visual Studio alt.png");
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(358, 269);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 26);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdbDetails
            // 
            this.rdbDetails.AutoSize = true;
            this.rdbDetails.Checked = true;
            this.rdbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDetails.Location = new System.Drawing.Point(360, 68);
            this.rdbDetails.Name = "rdbDetails";
            this.rdbDetails.Size = new System.Drawing.Size(71, 22);
            this.rdbDetails.TabIndex = 6;
            this.rdbDetails.TabStop = true;
            this.rdbDetails.Text = "Details";
            this.rdbDetails.UseVisualStyleBackColor = true;
            this.rdbDetails.CheckedChanged += new System.EventHandler(this.rdbDetails_CheckedChanged);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(360, 91);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(91, 22);
            this.rdLarge.TabIndex = 7;
            this.rdLarge.Text = "LargeIcon";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdSmallIcon
            // 
            this.rdSmallIcon.AutoSize = true;
            this.rdSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmallIcon.Location = new System.Drawing.Point(360, 114);
            this.rdSmallIcon.Name = "rdSmallIcon";
            this.rdSmallIcon.Size = new System.Drawing.Size(91, 22);
            this.rdSmallIcon.TabIndex = 8;
            this.rdSmallIcon.Text = "SmallIcon";
            this.rdSmallIcon.UseVisualStyleBackColor = true;
            this.rdSmallIcon.CheckedChanged += new System.EventHandler(this.rdSmallIcon_CheckedChanged);
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdList.Location = new System.Drawing.Point(360, 138);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(49, 22);
            this.rdList.TabIndex = 9;
            this.rdList.TabStop = true;
            this.rdList.Text = "List";
            this.rdList.UseVisualStyleBackColor = true;
            this.rdList.CheckedChanged += new System.EventHandler(this.rdList_CheckedChanged);
            // 
            // rdTile
            // 
            this.rdTile.AutoSize = true;
            this.rdTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTile.Location = new System.Drawing.Point(360, 162);
            this.rdTile.Name = "rdTile";
            this.rdTile.Size = new System.Drawing.Size(49, 22);
            this.rdTile.TabIndex = 10;
            this.rdTile.TabStop = true;
            this.rdTile.Text = "Tile";
            this.rdTile.UseVisualStyleBackColor = true;
            this.rdTile.CheckedChanged += new System.EventHandler(this.rdTile_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Escala";
            // 
            // txt_Valor3
            // 
            this.txt_Valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor3.Location = new System.Drawing.Point(251, 277);
            this.txt_Valor3.Name = "txt_Valor3";
            this.txt_Valor3.Size = new System.Drawing.Size(88, 24);
            this.txt_Valor3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mecado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lenguaje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(358, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Trasladar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor1.Location = new System.Drawing.Point(84, 231);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(93, 24);
            this.txt_Valor1.TabIndex = 20;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor2.Location = new System.Drawing.Point(251, 231);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(88, 24);
            this.txt_Valor2.TabIndex = 19;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Valor3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.rdTile);
            this.Controls.Add(this.rdList);
            this.Controls.Add(this.rdSmallIcon);
            this.Controls.Add(this.rdLarge);
            this.Controls.Add(this.rdbDetails);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvwListview);
            this.Controls.Add(this.chkCheckbox);
            this.MaximizeBox = false;
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCheckbox;
        private System.Windows.Forms.ListView lvwListview;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdbDetails;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.ImageList imglst;
        private System.Windows.Forms.RadioButton rdSmallIcon;
        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.RadioButton rdTile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Valor3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
    }
}