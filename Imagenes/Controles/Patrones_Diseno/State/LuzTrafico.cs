using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class LuzTrafico
    {
        public  IEstadoLuzTrafico Estado { get; set; }

        public void Cambiar()
        {
            Estado.Cambiar(this);
        }

        public TipoEstado GetEstado()
        {
            return Estado.GetEstado();
        }
    }
}
