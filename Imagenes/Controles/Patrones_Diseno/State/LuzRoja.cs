using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles 
{
    class LuzRoja : IEstadoLuzTrafico
    {
        public void Cambiar(LuzTrafico pLuz)
        {
            pLuz.Estado = new LuzVerde();
        }

        public TipoEstado GetEstado()
        {
            return TipoEstado.Rojo;
        }
    }
}
