using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class Registro : Form
    {
        Animaciones _Animacion = new Animaciones();
        public Registro()
        {
            InitializeComponent();
            _Animacion.IniciarFadeInAnimacion(this);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            _Animacion.IniciarFadeOutAnimacion(this);
        }
    }
}
