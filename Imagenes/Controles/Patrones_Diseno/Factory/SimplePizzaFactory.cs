using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{

    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            
            switch (type.ToUpper().Trim())
            {
                case "QUESO":
                    pizza = new CheesePizza();
                    break;
                case "PEPPERONI":
                    pizza = new PepperoniPizza();
                    break;

            }

            return pizza;
        }
    }

}
