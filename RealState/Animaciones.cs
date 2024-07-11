using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    internal class Animaciones
    {
        public void IniciarFadeInAnimacion(Form ventana)
        {
            Timer timer = new Timer();
            timer.Interval = 50; // Configura el intervalo a 50 milisegundos
            ventana.Opacity = 0; // Inicialmente el formulario es completamente transparente

            timer.Tick += (s, e) =>
            {
                if (ventana.Opacity < 1)
                {
                    ventana.Opacity += 0.05; // Incrementa la opacidad gradualmente
                }
                else
                {
                    timer.Stop(); // Detiene el timer cuando la opacidad llega a 1
                }
            };

            timer.Start(); // Inicia el timer
        }
        public void IniciarFadeOutAnimacion(Form Ventana)
        {
            Timer timer = new Timer();
            timer.Interval = 50; // Configura el intervalo a 50 milisegundos

            timer.Tick += (s, e) =>
            {
                if (Ventana.Opacity > 0)
                {
                    Ventana.Opacity -= 0.05; // Decrementa la opacidad gradualmente
                }
                else
                {
                    timer.Stop(); // Detiene el timer cuando la opacidad llega a 0
                    Ventana.Close(); // Cierra el formulario
                }
            };

            timer.Start(); // Inicia el timer
        }
    }
}
