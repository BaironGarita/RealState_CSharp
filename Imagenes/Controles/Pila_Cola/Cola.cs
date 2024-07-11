using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Controles
{
    class Cola
    {
        #region Atributos
        private Queue oCola;
        private String frasePalindrome;
        
        #endregion

        #region Constructor
        public Cola()
        {
            oCola = new Queue();
        }
        #endregion

        #region Métodos
       /// <summary>
       /// Agrega a la Cola
       /// </summary>
       /// <param name="pPalabra">Palindrome</param>
        public void Agregar(String pPalabra)
        {             
            // Recorrer cada caracter y introducirlo a la Pila
            // Como se recorre la cadena cada uno de sus valores es un Char
            // Noten: que elimino el espacio en blanco y paso todo a mayúscula
            // para realizar la comparación
           
            foreach (Char item in  pPalabra.Trim().ToUpper())
                oCola.Enqueue(item.ToString());

            // se Almacena la palabra para luego compararla
            frasePalindrome = pPalabra.Trim().ToUpper();

        }
       

        public Boolean EsPalindrome() { 
           
            String palabra = "";
            
            
            // note que cada vez que se invoca Pop Elimina el elemento de la Pila
            for (; oCola.Count > 0; )
            {
                palabra += oCola.Dequeue().ToString();
            }



             // Realiza la comparación sacando cada elemento de la pila
            return (frasePalindrome.CompareTo(palabra) == 0) ? true : false;

            
        }

        #endregion

    }
}
