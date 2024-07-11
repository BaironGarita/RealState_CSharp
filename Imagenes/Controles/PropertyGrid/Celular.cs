using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace Controles
{
    public class Celular
    {
        public enum Marcas { Motorola, Nokia, SamSung, Sonny };
        public enum Bandas { b850,b900,b1800,b1900,Todas};
        public enum Pixeles { Dos, Cuatro, Cinco, Diez, Doce, NO };
        public enum SI_o_NO { Si, No };

        public Celular() {
        }

        [Category("Serial")]
        [DisplayName("No de Serie")]
        [Description("Número de serie")]
        [ReadOnlyAttribute(true)] 
        public   String Serial { get; set; }
                       
        [Category("Fabricante")]
        [DisplayName("Fabricante")]
        [Description("Fabricante del Célular")]
        public Marcas Marca { get; set; }

        [Category("Características")]
        [DisplayName("Fecha")]
        [Description("Fecha")]
        public DateTime Fecha { get; set; }

        [DefaultValue(0.0f)]
        [Category("Características")]
        [Description("Duración Batería")]
        public  float Duracion_Bateria { get; set; }

        [Category("Características")]
        [Description("Bandas")]
        [DisplayName("Bandas 850/900/1800/1900")]
        public Bandas bandas { get; set; }

        [DefaultValue(Pixeles.NO)]
        [Category("Características")]
        [DisplayName("Pixeles Camara")]
        [Description("Pixeles Cámara")]
        public Pixeles camara { get; set; }

        [Category("Características")]
        [DisplayName("Posee Reloj")]
        [Description("Reloj")]
        public SI_o_NO Reloj{ get; set; }


        [Category("Características")]
        [Description("Alarma")]
        [DisplayName("Posee Alarma")]
         public SI_o_NO   Alarma { get; set; }

        [Category("Características")]
        [Description("Calendario")]
         public SI_o_NO   Calendario { get; set; }

        [Category("Características")]
        [DisplayName("Posee Wifi")]
        [Description("Wifi")]
        public SI_o_NO Wifi { get; set; }
        
         
        [Category("Otros")]
        [DisplayName("Observaciones")]
        [Description("Observaciones del Teléfono")]
        public String Observaciones{ get; set; }

        [Browsable(false)]
        public override String ToString() {
            return "No Serie:"+Serial.ToString() + " " + this.Marca.ToString();
        }


    }
}
