﻿namespace Controles
{
    partial class frmSprite
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
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmr_Timer
            // 
            this.tmr_Timer.Enabled = true;
            this.tmr_Timer.Tick += new System.EventHandler(this.tmr_Timer_Tick);
            // 
            // frmSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 316);
            this.Name = "frmSprite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprite";
            this.Load += new System.EventHandler(this.frmSprite_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSprites_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Timer;
    }
}