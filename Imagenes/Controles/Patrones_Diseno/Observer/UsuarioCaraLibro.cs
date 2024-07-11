using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    class UsuarioCaraLibro : IObserver
    {

        #region Properties
        private ISubject _Observer;
        private string Nombre;
        private string Apellido;
        private ListView _ListView; 
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pObservador">Subject</param>
        /// <param name="pNombre">Nombre</param>
        /// <param name="pApellido">Apellido</param>
        /// <param name="pListView">ListView</param>
        public UsuarioCaraLibro(ISubject pObservador, string pNombre, string pApellido, ListView pListView)
        {
            _Observer = pObservador;
            Nombre = pNombre;
            Apellido = pApellido;
            _ListView = pListView;
        } 
        #endregion
        
        #region M/todos
        /// <summary>
        /// Actualiza el Objeto
        /// </summary>
        /// <param name="pMensaje"></param>
        public void Update(string pMensaje)
        {
            ListViewItem item = new ListViewItem();
            item.ImageIndex = 1;
            item.Text = pMensaje;
            _ListView.Items.Add(item);
        } 
        #endregion

    }
}
