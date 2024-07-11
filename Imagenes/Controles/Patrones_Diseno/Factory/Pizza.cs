using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Controles
{
    abstract public class Pizza   
    {
        #region Interfaz
        private string Nombre {set;get;}
        private string Pasta { set; get; }
        private string Salsa { set; get; }
        public List<string> Toppings  
        {
            get { return toppings; }
        }
        #endregion

        #region Atributos
        private List<string> toppings = new List<string>();
        private ArrayList procesos = new ArrayList();
        #endregion

        #region Constructor
        public Pizza(string name, string dough, string sauce)
        {
            this.Nombre = name;
            this.Pasta = dough;
            this.Salsa = sauce;
          
        }

        #endregion

        #region Métodos

        public void Prepare()
        {
            procesos.Add("Preparando " + Nombre);
            
        }

        public void Bake()
        {
            procesos.Add("Cocinando " + Nombre);

        }

        public void Cut()
        {
            procesos.Add("Rebanando " + Nombre);

        }

        public void Box()
        {
            procesos.Add("Empacando " + Nombre); ;
        }

        
        

        // code to display pizza name and ingredients
        public override  string ToString()
        {
            
            StringBuilder display = new StringBuilder();
            
            display.Append("---- " + Nombre + " ----\n");
            display.Append("---- Proceso ----\n");
            foreach (string proceso in procesos)
            {
                display.Append(proceso + "\n");
            }

            display.Append("--------------------\n");
            display.Append("Pasta :" + Pasta + "\n");
            display.Append("Salsa :" + Salsa + "\n");
            display.Append("---- Ingredientes ----\n");
            foreach (string topping in toppings)
            {
                display.Append(topping + "\n");
            }

            return display.ToString();
        }
        #endregion
    }
}
