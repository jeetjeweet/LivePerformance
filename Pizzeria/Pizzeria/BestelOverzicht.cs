using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class BestelOverzicht : Form
    {
        public BestelOverzicht()
        {
            InitializeComponent();
        }

        private void btnBestelOverzichtBestellen_Click(object sender, EventArgs e)
        {

        }

        private void BestelOverzicht_Load(object sender, EventArgs e)
        {
            //foreach(Pizza pizza in Bestelling.pizzalist)
            //{
            //    lbBestellingPizzas.Items.Add(pizza);
            //}
            //foreach(Product product in Bestelling.productlist)
            //{
            //    lbBestellingProducten.Items.Add(product);
            //}
        }

        private void BestelOverzicht_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
