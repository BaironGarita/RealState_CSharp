using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles 
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza() :
            base("Pepperoni Pizza", "Pasta", "Salsa Marinada")
        {
            Toppings.Add("Pepperoni");
            Toppings.Add("Cebolla Onion");
            Toppings.Add("Queso parmesano");
        }
    }
}
