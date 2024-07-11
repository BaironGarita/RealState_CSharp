using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    interface IEncripta
    {
        string Encriptar(string pCadena);
        string Desencriptar(string pCadena);
    }
}
