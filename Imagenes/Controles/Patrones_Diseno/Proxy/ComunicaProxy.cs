using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    class ComunicaProxy : IComunica
    {
        private Comunica _Comunica = new Comunica();

        public void Habla(string pFrase, int pVelocidad, int pVolumen)
        {
            _Comunica.Habla( pFrase,  pVelocidad,  pVolumen);
        }
    }
}
