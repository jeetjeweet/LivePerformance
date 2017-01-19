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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAlleProducten_Click(object sender, EventArgs e)
        {
            GetAll ga = new GetAll("Product");
            this.Hide();
            ga.Show();
        }

        private void btnAllePizzas_Click(object sender, EventArgs e)
        {
            GetAll ga = new GetAll("Pizza");
            this.Hide();
            ga.Show();
        }

        private void btnAlleIngrediënten_Click(object sender, EventArgs e)
        {
            GetAll ga = new GetAll("Ingrediënt");
            this.Hide();
            ga.Show();

        }

        private void btnBestelOverzicht_Click(object sender, EventArgs e)
        {
            BestelOverzicht bo = new BestelOverzicht();
            this.Hide();
            bo.Show();
        }

        private void btnBestellen_Click(object sender, EventArgs e)
        {
            BestelKeuze bk = new BestelKeuze();
            this.Hide();
            bk.Show();
        }
    }
}
