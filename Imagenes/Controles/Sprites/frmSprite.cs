using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Ejemplo tomado y adaptado de
/// http://csharphelper.com/blog/2015/03/use-sprites-to-animate-several-bouncing-balls-in-c/
/// </summary>
namespace Controles
{
    public partial class frmSprite : Form
    {
        // Sprites.
        private SpriteBalon[] Sprites;
        private Size FormSize;

        public frmSprite()
        {
            InitializeComponent();
        }

        private void frmSprite_Load(object sender, EventArgs e)
        {
            // Random balones
            Random rand = new Random();
            const int numero_balones = 1;
            Sprites = new SpriteBalon[numero_balones];

            for (int i = 0; i < numero_balones; i++)
            {
                Sprites[i] = new SpriteBalon(10, 40,
                    ClientSize.Width, ClientSize.Height,
                    2, 10);
            }

            // Salvar el tamano del form   
            FormSize = ClientSize;

            // Reduce flicker.
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        /// <summary>
        /// Re printar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSprites_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);

            foreach (SpriteBalon sprite in Sprites)
                sprite.Draw(e.Graphics);
        }

        /// <summary>
        /// Timer para mover todos los balones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            foreach (SpriteBalon sprite in Sprites)
                sprite.Move();
            Refresh();
        }
    }
}
