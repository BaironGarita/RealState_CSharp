using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles
{
    interface IComunica
    {
        void Habla(string pFrase, int pVelocidad, int pVolumen); 
    }
}
