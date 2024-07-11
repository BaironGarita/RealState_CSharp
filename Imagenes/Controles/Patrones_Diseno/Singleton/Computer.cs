using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


namespace Controles
{

    /// <summary>
    // El patrón singleton provee una única instancia global
    // gracias a que:
    //  1-La propia clase es responsable de crear la única instancia.
    //  2-Permite el acceso global a dicha instancia mediante un método de clase.
    //  3-Declara el constructor de clase como privado para que no sea instanciable directamente.

    /// </summary>
    class Computer
    {

  
        #region Singleton
        private static Computer instance;

        /// <summary>
        /// OJO constructor privado !
        /// </summary>
        private Computer() { }

        /// <summary>
        /// Obtener Instancia
        /// </summary>
        public static Computer Instance()
        {
           
                // Si la instancia es NULL osea NO SE HA CREADO 
                // entonces debe crearla
                if (instance == null)
                {
                    instance = new Computer();
                }

                // Si no entra al IF anterior devuelve la Instancia actual
                return instance;
            
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve la información del Host
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            return string.Format("HostName: {0}, IP {1}", Dns.GetHostName(), IPAddresses(Dns.GetHostName()));
        }

        /// <summary>
        /// Obtiene las IP que tenga el servidor !
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        private string IPAddresses(string pServer)
        {

            // Get server related information.
            IPAddress[] direcciones = Dns.GetHostAddresses(pServer);
            StringBuilder lista = new StringBuilder();


            for (int i = 0; i < direcciones.Length; i++)
            {
                if (direcciones[i].AddressFamily.ToString().ToUpper().CompareTo("INTERNETWORK") == 0)
                    lista.AppendFormat("{0}", direcciones[i].ToString());
            }

            return lista.ToString();

        }
        #endregion
    }
}
