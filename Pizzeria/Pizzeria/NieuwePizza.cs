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
    public partial class NieuwePizza : Form
    {
        private PizzaRepository pizzaRepo = new PizzaRepository(new MSSQLPizzaContext());
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());
        List<Ingrediënt> ingredientlist;

        public NieuwePizza()
        {
            InitializeComponent();
        }

        private void btnNieuwePizzaOpslaan_Click(object sender, EventArgs e)
        {
            if(tbNieuwePizzaFormaat.Text == "" || tbNieuwePizzaNaam.Text == "" || cbNieuwePizzaBodem.SelectedItem == null || cbNieuwePizzaVorm.SelectedItem == null || lbNieuwePizzaIngrediëntenOpPizza.Items == null)
            {
               MessageBox.Show("Een van de velden is leeg gelaten, vul deze alsnog in");
            }
            else
            {
                Pizza pizza = new Pizza(tbNieuwePizzaNaam.Text,(Vorm)Enum.Parse(typeof(Vorm),Convert.ToString(cbNieuwePizzaVorm.SelectedItem)),(Bodem)Enum.Parse(typeof(Bodem),Convert.ToString(cbNieuwePizzaBodem.SelectedItem)),tbNieuwePizzaFormaat.Text,true);
                List<Ingrediënt> ilist = new List<Ingrediënt>();
                foreach (Ingrediënt i in ingredientlist)
                {
                    foreach (string s in lbNieuwePizzaIngrediëntenOpPizza.Items)
                    {
                        if (i.ToString() == s)
                        {
                            ilist.Add(i);
                        }
                }
                }
               
                
                if(pizzaRepo.AddPizza(pizza,ilist))
                {
                    MessageBox.Show("De nieuwe pizza is aangemaakt");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan met het aanmaken van de pizza, probeer het opnieuw.");
                }
            }
        }

        private void NieuwePizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetAll ga = new GetAll("Pizza");
            ga.Show();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if(lbNieuwePizzaIngrediënten.SelectedItem == null)
            {
                MessageBox.Show("selecteer een ingrediënt");
            }
            else
            {
                int index = lbNieuwePizzaIngrediënten.SelectedIndex;
                Ingrediënt i = ingredientlist[index];
                lbNieuwePizzaIngrediëntenOpPizza.Items.Add(i.ToString());
            }

        }

        private void NieuwePizza_Load(object sender, EventArgs e)
        {
            ingredientlist = ingredientRepo.GetAll();
            foreach(Ingrediënt i in ingredientlist)
            {
                lbNieuwePizzaIngrediënten.Items.Add(i.ToString());
            }
        }
    }
}
