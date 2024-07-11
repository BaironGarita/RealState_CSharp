using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class Comida 
    {

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString() => $"{Id} {Descripcion}";
         

    }
}
