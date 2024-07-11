using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{
    class Ipod
    {
       
        #region Atributos
        private Dictionary<String,Cancion>  diccionario;
        #endregion

        #region Constructor
        public Ipod() {

            // Iniciar el Diccionario
            diccionario = new Dictionary<string, Cancion>();
             
        }
        #endregion

        #region Métodos
        public void AgregarCancion(Cancion pCancion) {
            try
            {
                // En caso que el código de la canción YA existe,
                // se dispara una excepción por duplicidad
                diccionario.Add(pCancion.Codigo, pCancion);

               
            }
            catch (Exception er){
                // Se captura la excepción la cual recoge el
                // try catch que lo invoca 
                throw new Exception("OJO :"+er.Message);
            }
        }

        #endregion

    }
}
