using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Controles
{

    class Pila
    {
        private Stack oPila;
        private String frasePalindrome;

        #region Constructor
        public Pila()
        {
            oPila = new Stack();
        }
        #endregion


        #region Métodos
        /// <summary>
        /// Agrega Elemento en la Pila
        /// </summary>
        /// <param name="pValor"></param>
        public void Agregar(String pPalabra)
        {
            // Recorrer cada caracter e introducirlo a la Pila
            // Como se recorre la cadena cada uno de sus valores es un Char
            // Noten: que elimino el espacio en blanco y paso todo a mayúscula
            // para realizar la comparación
           
            foreach (Char item in  pPalabra.Trim().ToUpper())
                oPila.Push(item.ToString());

            // se Almacena la palabra para luego compararla
            frasePalindrome = pPalabra.Trim().ToUpper();

        }
        

        public Boolean EsPalindrome() { 
           
            String palabra = "";
            
            
            // note que cada vez que se invoca Pop Elimina el elemento de la Pila
            for (; oPila.Count > 0 ;)
            {
                palabra += oPila.Pop().ToString();
            }



             // Realiza la comparación sacando cada elemento de la pila
            return (frasePalindrome.CompareTo(palabra) == 0) ? true : false;

            
        }

        #endregion

    }






}
