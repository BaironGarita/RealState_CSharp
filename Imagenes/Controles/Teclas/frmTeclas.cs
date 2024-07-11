using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmTeclas : Form
    {
        public frmTeclas()
        {
            InitializeComponent();
        }


        private void frmTeclas_Load(object sender, EventArgs e)
        {
            this.pbiNave.BackColor = Color.Transparent;
             

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            
            if (keyData == Keys.Up)
            {
                // imagen Superturbo por acceso de propiedades
                pbiNave.Image = Controles.Properties.Resources.superturbo;

                pbiNave.Location = new Point(this.pbiNave.Location.X, (int)this.pbiNave.Location.Y - 20);
                //pbiNave.Image = Controles.Properties.Resources.turbo;

            }

            if (keyData == Keys.Down)
            {
                pbiNave.Image = Controles.Properties.Resources.turbo;
                pbiNave.Location = new Point(this.pbiNave.Location.X, (int)this.pbiNave.Location.Y + 20);

            }

            if (keyData == Keys.Left)
            {
                pbiNave.Image = Controles.Properties.Resources.turbo;
                pbiNave.Location = new Point(this.pbiNave.Location.X - 20, (int)this.pbiNave.Location.Y);

            }

            if (keyData == Keys.Right)
            {
                pbiNave.Image = Controles.Properties.Resources.turbo;
                pbiNave.Location = new Point(this.pbiNave.Location.X + 20, (int)this.pbiNave.Location.Y);

            }
            pbiNave.Refresh();

            this.Refresh();

            return base.ProcessCmdKey(ref msg, keyData);

        }

    }
}
