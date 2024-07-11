using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class LuzAmarilla : IEstadoLuzTrafico
    {
        public void Cambiar(LuzTrafico pLuz)
        {
            pLuz.Estado = new LuzRoja();
        }

        public TipoEstado GetEstado()
        {
            return TipoEstado.Amarillo;
        }
    }
}
