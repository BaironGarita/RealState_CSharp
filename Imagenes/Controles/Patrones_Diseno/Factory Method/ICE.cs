using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    public class ICE:IProveedor
    {

        private int cantidadMinutos;
        private int cantidadMensajes;

        public void AgregarMinutos(int pCantidadMinutos)
        {
            cantidadMinutos = pCantidadMinutos;
        }

        public void AgregarMensajes(int pCantidadMensajes)
        {
            cantidadMensajes = pCantidadMensajes;
        }

        public double MontoPagar()
        {

            double monto = 0d;
            monto = cantidadMinutos * 3;
            monto += cantidadMensajes * 17.5;

            return monto;

        }
    }
}
