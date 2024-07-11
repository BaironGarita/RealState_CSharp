using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using System.Reflection;
using System;

namespace Controles
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void botonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void botonesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmBoton 
            // para crear el objeto
            frmBoton ofrmVentana = new frmBoton();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();         

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmCheckBox 
            // para crear el objeto
             
            frmCheckbox ofrmVentana = new frmCheckbox();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
          
        }



        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmComboBox
            // para crear el objeto
            frmComboBox ofrmVentana = new frmComboBox();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();

            
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmListBox
            // para crear el objeto
            frmListBox ofrmVentana = new frmListBox();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();

            
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmListView
            // para crear el objeto
            frmListView ofrmVentana = new frmListView();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();

            
        }

        private void dataTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmDataTimePicker
            // para crear el objeto
            frmDataTimePicker ofrmVentana = new frmDataTimePicker();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();

           
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Se declara la instancia a la clase frmMaskedTextBox
            // para crear el objeto
            frmMaskedTextBox ofrmVentana = new frmMaskedTextBox();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();

          
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmNumericUpDown
            // para crear el objeto
            frmNumericUpDown ofrmVentana = new frmNumericUpDown();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmProgressBar
            // para crear el objeto
            frmProgressBar ofrmVentana = new frmProgressBar();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmTreeView
            // para crear el objeto
            frmTreeView2 ofrmVentana = new frmTreeView2();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
        }

        private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmToolTip
            // para crear el objeto
            frmToolTip ofrmVentana = new frmToolTip();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void rickTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmToolTip
            // para crear el objeto
            frmRichText ofrmVentana = new frmRichText();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmGrid
            // para crear el objeto
            frmGrid ofrmVentana = new frmGrid();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmTabControl
            // para crear el objeto
            frmTabControl ofrmVentana = new frmTabControl();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmTimer
            // para crear el objeto
            frmTimer ofrmVentana = new frmTimer();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
        }

        private void toolStripToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmToolStrip
            // para crear el objeto
            frmToolStrip ofrmVentana = new frmToolStrip();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void statusStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se declara la instancia a la clase frmStatusStrip
            // para crear el objeto
            frmStatusStrip ofrmVentana = new frmStatusStrip();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
        }


        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAcercade ofrmVentana = new frmAcercade();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColorDialog ofrmVentana = new frmColorDialog();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 

        }

        private void folderBrowserDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolderBrowserDialog ofrmVentana = new frmFolderBrowserDialog();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
 
        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmOpenFileDialog ofrmVentana = new frmOpenFileDialog();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
             
        }

        private void conversionesDeTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConversionesdeTipo ofrmVentana = new frmConversionesdeTipo();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
           
        }

        private void manejoDeStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoString ofrmVentana = new frmManejoString();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;           
            // Despliega el form
            ofrmVentana.Show();
           
        }

        private void númerosAleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumerosAleatorios ofrmVentana = new frmNumerosAleatorios();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
       
            // Despliega el form
            ofrmVentana.Show();

        }

        private void teclasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeclas ofrmVentana = new frmTeclas();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show(); 
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXML ofrmVentana = new frmXML();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();
        }

        private void funcionesMatemáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionesMatematicas ofrmVentana = new frmFuncionesMatematicas();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();

        }

        private void ejecutableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjecutable ofrmVentana = new frmEjecutable();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();
        }

        private void ejemploAvionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
            frmEjemploAviones ofrmVentana = new frmEjemploAviones();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();

        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametros ofrmVentana = new frmParametros();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
             
            // Despliega el form
            ofrmVentana.Show();

        }

        private void gridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPropertyGrid ofrmVentana = new frmPropertyGrid();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Text = this.Text + " " + String.Format("{0}, Version  {1}", fvi.FileDescription, fvi.FileVersion);

            CulturaInfo();

            toolStripStatusLabel1.Text = String.Format("{0}, Version  {1}", fvi.FileDescription, fvi.FileVersion);
        }



        /// <summary>
        /// Tema de formatos de fecha, Culture y formato num/rico
        /// </summary>
        private void CulturaInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;

        }

        private void pilasYColasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilasColas ofrmVentana = new frmPilasColas();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
        
            // Despliega el form
            ofrmVentana.Show();

        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDictionary ofrmVentana = new frmDictionary();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
         
            // Despliega el form
            ofrmVentana.Show();

        }

        private void abstractFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbstractFactory ofrmVentana = new frmAbstractFactory();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void factoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactory ofrmVentana = new frmFactory();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();

        }

        private void factoryMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactoryMethod ofrmVentana = new frmFactoryMethod();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void singletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSingleton ofrmVentana = new frmSingleton();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();

        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSplitContainer ofrmVentana = new frmSplitContainer();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lambdaExpresionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLambdaExpresions ofrmVentana = new frmLambdaExpresions();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void threadsHilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjemploAviones ofrmVentana = new frmEjemploAviones();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();
        }

        private void UserControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserControl ofrmVentana = new frmUserControl();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
           
            // Despliega el form
            ofrmVentana.Show();
        }

        private void observerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObserver ofrmVentana = new frmObserver();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJSON ofrmVentana = new frmJSON();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
          
            // Despliega el form
            ofrmVentana.Show();
        }

        private void proxyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmProxy ofrmVentana = new frmProxy();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();

        }

        private void quickResponseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickResponse ofrmVentana = new frmQuickResponse();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void speakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpeak ofrmVentana = new frmSpeak();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            
            // Despliega el form
            ofrmVentana.Show();
        }

        private void spritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSprite ofrmVentana = new frmSprite();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
          
            // Despliega el form
            ofrmVentana.Show();
        }

        private void reflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReflection ofrmVentana = new frmReflection();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
             
            // Despliega el form
            ofrmVentana.Show();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmState ofrmVentana = new frmState();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;             
            // Despliega el form
            ofrmVentana.Show();
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjemploAviones ofrmVentana = new frmEjemploAviones();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;      
            // Despliega el form
            ofrmVentana.Show();
        }

        private void parallelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParallel ofrmVentana = new frmParallel();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
        }

        private void webApiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWebApi ofrmVentana = new frmWebApi();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
        }

        private void aSMXWebServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmWebService ofrmVentana = new frmWebService();
            // establece quien es el padre
            ofrmVentana.MdiParent = this;
            // Despliega el form
            ofrmVentana.Show();
        }

    }
}