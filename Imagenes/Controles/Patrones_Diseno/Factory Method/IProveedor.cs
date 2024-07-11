using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    public interface IProveedor{
    
        double MontoPagar();
        void AgregarMinutos(int pCantidadMinutos);
        void AgregarMensajes(int pCantidadMensajes);

    }
}
