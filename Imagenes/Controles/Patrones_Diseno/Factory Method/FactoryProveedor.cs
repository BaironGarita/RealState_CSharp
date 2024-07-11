using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class FactoryProveedor
    {

        public static IProveedor ObtenerProveedor(TipoProveedor pTipo) {

            IProveedor oProveedor = null;

            switch (pTipo)
            {
                case TipoProveedor.ICE:
                    oProveedor = new ICE();
                    break;
                case TipoProveedor.CLARO:
                    oProveedor = new Claro();
                    break; 
            }
             
            return oProveedor;
        
        }
    }
}
