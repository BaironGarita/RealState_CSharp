using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles 
{
    public class CheesePizza : Pizza
    {
        public CheesePizza() :
            base("Pizza de Queso", "Pasta Regular", "Salsa de Pizza Marinada")
        {
            Toppings.Add("Queso Mozzarella");
            Toppings.Add("Queso Parmesano");
        }
    }
}
