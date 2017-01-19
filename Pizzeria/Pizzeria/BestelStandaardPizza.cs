using Pizzeria.Database.MSSQL;
using Pizzeria.Database.Repositories;
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
    public partial class BestelStandaardPizza : Form
    {
        List<Pizza> pizzalist;
        private PizzaRepository pizzaRepo = new PizzaRepository(new MSSQLPizzaContext());

        public BestelStandaardPizza()
        {
            InitializeComponent();
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {
            if(lbStandaardPizzas.SelectedItem != null)
            {
                //int index = lbStandaardPizzas.SelectedIndex;
                //Pizza pizza = pizzalist[index];
                //Bestelling.pizzalist.Add(pizza);
                //MessageBox.Show("De pizza is succesvol aan de bestelling toegevoegd.");
            }
            else
            {
                MessageBox.Show("U heeft geen pizza geselecteerd, selecteer een pizza om door te gaan");
            }

        }

        private void btnBestelOverzicht_Click(object sender, EventArgs e)
        {
            BestelOverzicht bo = new BestelOverzicht();
            this.Close();
            bo.Show();
        }

        private void BestelStandaardPizza_Load(object sender, EventArgs e)
        {
            pizzalist = pizzaRepo.GetStandardPizza();
            foreach(Pizza p in pizzalist)
            {
                lbStandaardPizzas.Items.Add(p.ToString());
            }
        }

        private void BestelStandaardPizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}
