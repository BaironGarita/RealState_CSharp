using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmSpeak : Form
    {
        public frmSpeak()
        {
            InitializeComponent();
        }

     
        /// <summary>
        ///  Nota
        ///  HAy que agregar la referencia del SpeechSynthesizer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnHablar_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Volume = this.tcbVolumen.Value;
                voice.Rate = this.tcbVelocidad.Value;
                voice.SpeakAsync(richTextBox1.Text);
            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atención");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Speak_Load(object sender, EventArgs e)
        {

        }
    }
}
