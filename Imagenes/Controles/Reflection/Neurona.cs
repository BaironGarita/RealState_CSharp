using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles 
{
    class Neurona
    {
        public string Dentrita { get; set; }
        public string Soma { get; set; }
        public string Nucleus { get; set; }
        public string Sinampse { get; set; }
        public string Axon { get; set; }

        public int ContadorPublico =0;
        public int ContadorPrivado = 0;
        public static int ContadorStatic = 0;


        public void ValidarAxon() {
            //
        }

        private  int CalcularPotencial() {
            return 0;
        }

        public static void MetodoStatic() {
            //
        }

    }
}
