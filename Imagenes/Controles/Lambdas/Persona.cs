using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    class Persona
    {
        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public double Salario { set; get; }

        public override string ToString()
        {
            return string.Format("Soy {0} {1} y mi cedula es {2}", Nombre,Apellidos,Cedula);
        }


    }
}
