using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{

    interface IEstadoLuzTrafico
    {

        void Cambiar(LuzTrafico pLuz);

        TipoEstado GetEstado();
        
    }
}
