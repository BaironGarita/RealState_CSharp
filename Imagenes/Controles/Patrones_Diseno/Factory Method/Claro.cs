using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    public class Claro: IProveedor
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
            // mensajes a 5 colones y cada minuto a 23.5 
            double monto = 0d;
            monto = cantidadMinutos * 5;
            monto += cantidadMensajes * 23.5;

            return monto;

        }
    }
}
