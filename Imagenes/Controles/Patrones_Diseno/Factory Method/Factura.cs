using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    public class Factura
    {
        private IProveedor _Proveedor;
       
        public void AsignarProveedor(IProveedor pProveedor)
        {
            _Proveedor = pProveedor;
        }

        public void AgregarMinutos(int pCantidadMinutos) {
            _Proveedor.AgregarMinutos(pCantidadMinutos);        
        }

        public void AgregarMensajes(int pCantidadMensajes) {
            _Proveedor.AgregarMensajes(pCantidadMensajes);
        }

        public double MontoTotalPagar()
        {
            return _Proveedor.MontoPagar() + this.Impuesto();
        }

        private double Impuesto() {

            return _Proveedor.MontoPagar() * 0.13;
        }


    }
}
