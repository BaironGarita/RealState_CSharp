using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    class Provincia
    {
        public String Id { get; set; }
        public String Descripcion { set; get; }
        /*
        public override string ToString()
        {
            return $"{Id} - {Descripcion}";
        }
        */
  
        // Embodies
         public override string ToString() => $"{Id} - {Descripcion}";

    }
}
