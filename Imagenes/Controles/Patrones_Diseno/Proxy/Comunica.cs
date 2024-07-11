using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Controles 
{

    /*
     Nota debe agregar el ensamblado System.Speech  dar clic derecho en referencias,
     agregar referencia, escoger Assamblies, luego Framework y seleccionar    System.Speech
     
     */ 

    class Comunica : IComunica
    {
        public void Habla(string pFrase, int pVelocidad, int pVolumen)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Volume = pVolumen;
            voice.Rate = pVelocidad;
            voice.SpeakAsync(pFrase);
        }
    }
}
