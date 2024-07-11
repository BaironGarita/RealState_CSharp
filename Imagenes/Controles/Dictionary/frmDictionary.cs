using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Controles
{

    public partial class frmDictionary : Form
    {
        // Acceso a Dll
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        #region Atributos
        private Ipod oIpod = new Ipod();
        private Boolean IsPlaying  ;
        private String CurrentSong;
        #endregion


        public frmDictionary()
        {
            InitializeComponent();
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {
            IsPlaying = false;
            CurrentSong = "";
  
            // Crear los objetos Canción
            Cancion oCancion1 = new Cancion()
            {
                Codigo = "1",
                NombreCancion = "Through Glass",
                GeneroMusical = Cancion.Genero.Rock,
                //RutaArchivo =  @"C:\Users\UTN\Documents\Visual Studio 2008\Projects\Controles\Dictionary\ThroughGlass.mp3"
                RutaArchivo = @"..\..\Dictionary\ThroughGlass.mp3"

            };

            Cancion oCancion2 = new Cancion()
            {
                Codigo = "2",
                NombreCancion = "I Dont Want To Live Without You",
                GeneroMusical = Cancion.Genero.Pop,
                RutaArchivo = @"..\..\Dictionary\IDontWantToLiveWithoutYou.mp3"

            };

            Cancion oCancion3 = new Cancion()
            {
                Codigo = "3",
                NombreCancion = "Army of me",
                GeneroMusical = Cancion.Genero.Electronica,
                RutaArchivo = @"..\..\Dictionary\armyofme.mp3"

            };



            // Colocar los detalles de la vista
            lsvCancionesDisponibles.View = View.Tile;



            // Agregar una columna de 30 espacios con alienación izquierda.
            lsvCancionesDisponibles.Columns.Add("Código", 100, HorizontalAlignment.Left);
            lsvCancionesDisponibles.Columns.Add("Canción", 190, HorizontalAlignment.Left);
            lsvCancionesDisponibles.Columns.Add("Genero", 100, HorizontalAlignment.Left);

            // Crear Item que contiene el objeto y se muestra en el ListView
            ListViewItem item1 = new ListViewItem();
            item1.Tag = oCancion1;
            item1.Text = oCancion1.ToString();

            ListViewItem item2 = new ListViewItem();
            item2.Tag = oCancion2;
            item2.Text = oCancion2.ToString();

            ListViewItem item3 = new ListViewItem();
            item3.Tag = oCancion3;
            item3.Text = oCancion3.ToString();

            // agregar items
            this.lsvCancionesDisponibles.Items.Add(item1);
            this.lsvCancionesDisponibles.Items.Add(item2);
            this.lsvCancionesDisponibles.Items.Add(item3);


            // Subitems
            lsvCancionesDisponibles.Items[0].SubItems.Add(oCancion1.NombreCancion);
            lsvCancionesDisponibles.Items[1].SubItems.Add(oCancion2.NombreCancion);
            lsvCancionesDisponibles.Items[2].SubItems.Add(oCancion3.NombreCancion);


            // Subitem
            lsvCancionesDisponibles.Items[0].SubItems.Add(oCancion1.GeneroMusical.ToString());
            lsvCancionesDisponibles.Items[1].SubItems.Add(oCancion2.GeneroMusical.ToString());
            lsvCancionesDisponibles.Items[2].SubItems.Add(oCancion3.GeneroMusical.ToString());



            // indicar las imagenes a utilizar
            lsvCancionesDisponibles.Items[0].ImageIndex = 0;
            lsvCancionesDisponibles.Items[1].ImageIndex = 0;
            lsvCancionesDisponibles.Items[2].ImageIndex = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstIpodCanciones_DragDrop(object sender, DragEventArgs e)
        {

            try
            {
                // Se lee del lisview el elemento Seleccionado, el cual
                // tiene contenido en la propiedad TAG el objeto
                Cancion oCancion = (Cancion)lsvCancionesDisponibles.Items[lsvCancionesDisponibles.FocusedItem.Index].Tag;

                oIpod.AgregarCancion(oCancion);

                // se agrega el objeto a la lista en el Ipod
                lstIpodCanciones.Items.Add(oCancion);

                // seleccionar la canción que se acaba de ingresar
                lstIpodCanciones.SetSelected(lstIpodCanciones.Items.Count -1, true);

               
            }

            catch (Exception er)
            {
                MessageBox.Show("Ipod error :" + er.Message, "Atención");
            }


        }

        private void lstIpodCanciones_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lsvCancionesDisponibles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            lsvCancionesDisponibles.DoDragDrop(this.lstIpodCanciones.SelectedItems, DragDropEffects.Copy);


        }

        private void lstIpodCanciones_Click(object sender, EventArgs e)
        {
            Play();

        }

        private void Play()
        {
            String rutaArchivo = ((Cancion)lstIpodCanciones.SelectedItem).RutaArchivo;
            try
            {
                 
                // Si la canción que se está ejecutando es igual a la que se le hizo
                // significa que  se detenga
      
                if (IsPlaying == true && CurrentSong.CompareTo(((Cancion)lstIpodCanciones.SelectedItem).NombreCancion) == 0)
                {
                    CurrentSong = "";
                    Stop();
                    return;
                }

                // Si se esté ejecutando alguna canción cerrarla
                if (IsPlaying == true)
                {
                    Stop();
                }

                mciSendString("open \"" + rutaArchivo + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                IsPlaying = true;
                // Canción actual
                CurrentSong = ((Cancion)lstIpodCanciones.SelectedItem).NombreCancion;
            }
            catch (Exception er)
            {
                CurrentSong = "";
                MessageBox.Show("Error al ejecutar " + rutaArchivo + " " + er.Message, "Error");
                IsPlaying = false;
            }
        }

        private void Stop()
        {
            try
            {
                String command = "close MediaFile";
                mciSendString(command, null, 0, IntPtr.Zero);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al detener la canción !" + er.Message, "Error");
                IsPlaying = false;
            }
        }

        private void frmDictionary_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                String command = "close MediaFile";
                mciSendString(command, null, 0, IntPtr.Zero);
            }
            catch { }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "X " + e.X + " Y " + e.Y;
            // Teclas del Ipod
            //      Menu
            // |<<        >>|
            //      |>||
            

            // |<< 
            if ((e.X >= 86 && e.X <= 150) && e.Y >= 333 && e.Y <= 400)
            {

                if (lstIpodCanciones.SelectedIndex > 0)
                {
                    this.lstIpodCanciones.SelectedIndex = this.lstIpodCanciones.SelectedIndex - 1;
                    
                }
            }


            // >>|
            if ((e.X >= 253 && e.X <= 325) && e.Y >= 320 && e.Y <= 394)
            {

                if (lstIpodCanciones.SelectedIndex != lstIpodCanciones.Items.Count -1)
                {
                    this.lstIpodCanciones.SelectedIndex = this.lstIpodCanciones.SelectedIndex + 1 ;
                   
                }
            }

            //      Menu
            if ((e.X >= 150 && e.X <= 260) && e.Y >= 275 && e.Y <= 320)
            {
                // Opción no habilitada
              
            }


            //      |>||
            if ((e.X >= 158 && e.X <= 253) && e.Y >= 400 && e.Y <= 455)
            {
                Play();

            }

        } // fin de click sobre imagen del Ipod
    }
}
