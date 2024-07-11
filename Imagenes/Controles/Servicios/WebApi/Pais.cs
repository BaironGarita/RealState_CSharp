using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Se colocaron todos los objetos en un solo archivo que son parte de Pais
/// </summary>
namespace Controles
{
    
    class Pais    {        
        public Name Name { get; set; }        
        public Flags Flags { get; set; }
    }

   
    public class Name
    {       
        public string Common { get; set; }       
        public string Official { get; set; }

    }
   
    public class Flags
    {      
        public string Png { get; set; }       
        public string Svg { get; set; }
    }
}
