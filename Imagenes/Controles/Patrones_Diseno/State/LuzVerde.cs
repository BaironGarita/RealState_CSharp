using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class LuzVerde : IEstadoLuzTrafico
    {
        public void Cambiar(LuzTrafico pLuz)
        {
            pLuz.Estado = new LuzAmarilla();
        }

        public TipoEstado GetEstado()
        {
            return TipoEstado.Verde;
        }
    }
}
