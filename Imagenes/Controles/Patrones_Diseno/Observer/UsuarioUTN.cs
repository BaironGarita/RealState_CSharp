using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controles
{

    /// <summary>
    /// Concrete Subject
    /// </summary>
    class UsuarioUTN : ISubject
    {
        #region Properties
        private List<IObserver> _ListaObservadores;
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Mensaje { set; get; } 
        #endregion

        #region Constructor
        public UsuarioUTN()
        {
            _ListaObservadores = new List<IObserver>();
        } 
        #endregion

        #region M/todos

        /// <summary>
        /// Registra el objeto que se desea observar
        /// </summary>
        /// <param name="o"></param>
        public void RegisterObserver(IObserver o)
        {
            _ListaObservadores.Add(o);
        }

        /// <summary>
        /// elimina el Objeto que YA no se desea observar
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o)
        {
            _ListaObservadores.Remove(o);
        }

        /// <summary>
        /// Notifica a todos los Objetos Registrados de cambios realizados en el Subject
        /// </summary>
        public void NotifyObserver()
        {
            foreach (IObserver observer in _ListaObservadores)
            {
                observer.Update(Mensaje);
            }
        } 
        #endregion
    }
}
