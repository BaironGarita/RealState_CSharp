using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Controles
{
    public partial class frmFuncionesMatematicas : Form
    {
        public frmFuncionesMatematicas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {



            int width = 800;
            int height = 900;

            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                int y = (int)((Math.Sin((double)i * 2.0 * Math.PI / width) + 1.0) * (height - 1) / 2.0);
                bitmap.SetPixel(i, y, Color.Black);
            }


            this.pbImagen.Image = bitmap;

        }

        private void btnSenoLineal_Click(object sender, EventArgs e)
        {



            // linea utilizando el Seno
            Pen lapiz = new Pen(System.Drawing.Color.Blue, 3);
            Graphics miGrafico = pbImagen.CreateGraphics();
            miGrafico.Clear(Color.White);
            for (int contador = 0; contador <= 1000; contador++)
            {
                miGrafico.DrawLine(lapiz, contador, 100 + (int)(Math.Sin(contador)), contador + 1, 100 + (int)(Math.Sin(contador + 1)));
            }

        }

        private void pbImagen_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = "X =" + e.X + " Y=" + e.Y;
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            Pen penCurrent = new Pen(Color.Blue);


            PointF[] pt = { new PointF(21,338),
                            new PointF(11,68),  
                            new PointF(5,2 ),
                            new PointF(-1,8 ),
                            new PointF(-9, 128)
                          };

            Graphics miGrafico = pbImagen.CreateGraphics();
            miGrafico.Clear(Color.White);
            // centrado de dibujo
            miGrafico.TranslateTransform(this.Width / 2, this.Height / 2);
            miGrafico.ScaleTransform(7, -2);
            miGrafico.DrawCurve(penCurrent, pt);

            // líneas 
            //miGrafico.DrawLine(new Pen(Color.Black), new Point(1, 187), new Point(538, 187));
            //miGrafico.DrawLine(new Pen(Color.Black), new Point(245, 1), new Point(245, 396));


        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            int width = 800;
            int height = 900;

            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                int y = (int)((Math.Cos((double)i * 2.0 * Math.PI / width) + 1.0) * (height - 1) / 2.0);
                bitmap.SetPixel(i, y, Color.Black);
            }

            this.pbImagen.Image = bitmap;

        }
    }
}
