using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles 
{
    class Wolf : Carnivore
    {
        public override string  Come(Herbivore h)
        {
            // Eat Bison
            return this.GetType().Name + " se come a " + h.GetType().Name;
        }
    }
}
