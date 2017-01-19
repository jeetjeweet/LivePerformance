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
    public partial class BestelKeuze : Form
    {
        public BestelKeuze()
        {
            InitializeComponent();
        }

        private void btnStandaardPizzas_Click(object sender, EventArgs e)
        {
            BestelStandaardPizza bsp = new BestelStandaardPizza();
            this.Close();
            bsp.Show();
        }

        private void btnPizzaSamenstellen_Click(object sender, EventArgs e)
        {

        }

        private void btnProducten_Click(object sender, EventArgs e)
        {

        }

        private void btnBestelOverzicht_Click(object sender, EventArgs e)
        {
            BestelOverzicht bo = new BestelOverzicht();
            this.Close();
            bo.Show();
        }

        private void BestelKeuze_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}
