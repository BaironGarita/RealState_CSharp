using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmToolTip : Form
    {
        public frmToolTip()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmToolTip_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            ToolTip t = new ToolTip();
         
            

            if (e.KeyCode == Keys.K) {
                 
                t.ToolTipTitle = "titulo";
                t.ToolTipIcon = ToolTipIcon.Info;
                t.IsBalloon = true;                
                t.ShowAlways = true;

                 
                t.Show("Text to display", textBox1, new Point(textBox1.Width + 20, 0), 2000);
              //  t.SetToolTip(this.textBox1, "Hello");

            }
        }
 
    }
}