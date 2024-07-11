using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles 
{ 
    /// <summary>
    /// Simple Factory no es actualmente un patrón de diseño, es mas 
    /// un idioma de programación, pero comunmente es usado.
    /// Según el libro Head First Design Patterns es un Patrón con mención
    /// honorable.
    /// Este Patrón es importante para entender Abstract Factory y Method Factory.
    /// </summary>
    public partial class frmFactory : Form
    {
        public frmFactory()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPizzaQueso_Click(object sender, EventArgs e)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("Queso");
            this.rtbDetalle.Clear();
            this.rtbDetalle.AppendText(pizza.ToString());
            
        }

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            Pizza pizza = store.OrderPizza("PEPPERONI");
            this.rtbDetalle.Clear();
            this.rtbDetalle.AppendText(pizza.ToString());
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {

        }
    }
}
