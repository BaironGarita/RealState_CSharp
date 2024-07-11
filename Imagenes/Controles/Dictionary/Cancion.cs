using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{

   

    public class Cancion
    {
        public enum Genero { Rock, Pop, Electronica }
        #region Atributos
        public String Codigo { set; get; }
        public String NombreCancion { set; get; }
        public Genero GeneroMusical { set; get; }
        public String RutaArchivo { set; get; }
        #endregion

        #region Métodos
        public override String ToString() {
            return Codigo + " " + NombreCancion;
        }

        #endregion


    }
}
