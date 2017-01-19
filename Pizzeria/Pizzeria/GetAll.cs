using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzeria.Database.Repositories;
using Pizzeria.Database.MSSQL;
namespace Pizzeria
{
    public partial class GetAll : Form
    {
        private PizzaRepository pizzaRepo = new PizzaRepository(new MSSQLPizzaContext());
        private List<Pizza> pizzalist;
        private List<Ingrediënt> ingredientlist;
        private List<Product> productlist;

        private string soort { get; set; }

        public GetAll(string soort)
        {
            this.soort = soort;
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void GetAll_Load(object sender, EventArgs e)
        {
            if (this.soort == "Pizza")
            {
                lblGetAll.Text = "Alle pizza's";
                pizzalist = pizzaRepo.GetStandardPizza();
                foreach (Pizza p in pizzalist)
                {
                    lbGetAll.Items.Add(p.ToString());
                }
            }
            else if (this.soort == "Ingrediënt")
            {
                lblGetAll.Text = "Alle Ingrediënten";
            }
            else if (this.soort == "Product")
            {
                lblGetAll.Text = "Alle Producten";
            }

        }

        private void GetAll_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
