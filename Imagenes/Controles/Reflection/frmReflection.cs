using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmReflection : Form
    {
        public frmReflection()
        {
            InitializeComponent();
        }

        private void frmReflection_Load(object sender, EventArgs e)
        {
            try
            {
                 
                Neurona oNeurona = new Neurona();
                // Get the Type information.
                Type myTypeObj = oNeurona.GetType();
                // Get Method Information.
                var miembros = myTypeObj.GetMembers(BindingFlags.Public | 
                                                    BindingFlags.Instance |
                                                    BindingFlags.Static |
                                                    BindingFlags.NonPublic );

                foreach (MemberInfo item in miembros)
                {
 
                   string[] datos =  { item.Name, item.MemberType.ToString()  };

                   dgvDatos.Rows.Add(datos);
                }


            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message,"Atención");
            }
        }

        /// <summary>
        /// Sobre escribe el Método y permite que cuando se digite cualquier tecla en 
        /// este caso Escape cerrará la ventana o ejecutará una acción.
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (  keyData == Keys.Escape)
            {
                this.Close();
                //return false;
            } 
            
            return base.ProcessDialogKey(keyData);
        }

      

    }
}
