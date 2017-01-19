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
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());
        private ProductRepository productRepo = new ProductRepository(new MSSQLProductContext());
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
            if(this.soort == "Pizza")
            {
                NieuwePizza np = new NieuwePizza();
                this.Close();
                np.Show();
            }
            else if (this.soort == "Ingrediënt")
            {
                NieuwIngrediënt ni = new NieuwIngrediënt();
                this.Close();
                ni.Show();
            }
            else if (this.soort == "Product")
            {
                NieuwProduct nieuwproduct = new NieuwProduct();
                this.Close();
                nieuwproduct.Show();
            }
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            if (this.soort == "Pizza")
            {

            }
            else if (this.soort == "Ingrediënt")
            {

            }
            else if (this.soort == "Product")
            {

            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (this.soort == "Pizza")
            {
                if(lbGetAll.SelectedItem == null)
                {
                    MessageBox.Show("Selecteer een pizza.");
                }
                else
                {
                    int index = lbGetAll.SelectedIndex;
                    Pizza pizza = pizzalist[index];
                    if (pizzaRepo.Delete(pizza))
                    {
                        MessageBox.Show("De pizza is verwijderd");
                        lbGetAll.Items.Clear();
                        pizzalist = pizzaRepo.GetStandardPizza();
                        foreach (Pizza p in pizzalist)
                        {
                            lbGetAll.Items.Add(p.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("De pizza is niet verwijderd");
                    }
                }
            }
            else if (this.soort == "Ingrediënt")
            {
                if (lbGetAll.SelectedItem == null)
                {
                    MessageBox.Show("Selecteer een ingrediënt.");
                }
                else
                {
                    int index = lbGetAll.SelectedIndex;
                    Ingrediënt ingredient = ingredientlist[index];
                    if (ingredientRepo.Delete(ingredient))
                    {
                        MessageBox.Show("Het ingrediënt is verwijderd");
                        lbGetAll.Items.Clear();
                        ingredientlist = ingredientRepo.GetAll();
                        foreach (Ingrediënt i in ingredientlist)
                        {
                            lbGetAll.Items.Add(i.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Het ingrediënt is niet verwijderd");
                    }
                }
            }
            else if (this.soort == "Product")
            {
                if (lbGetAll.SelectedItem == null)
                {
                    MessageBox.Show("Selecteer een product.");
                }
                else
                {
                    int index = lbGetAll.SelectedIndex;
                    Product product = productlist[index];
                    if (productRepo.Delete(product))
                    {
                        MessageBox.Show("Het product is verwijderd");
                        lbGetAll.Items.Clear();
                        productlist = productRepo.GetAll();
                        foreach (Product p in productlist)
                        {
                            lbGetAll.Items.Add(p.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Het product is niet verwijderd");
                    }
                }
            }
        }

        private void GetAll_Load(object sender, EventArgs e)
        {
            lbGetAll.Items.Clear();
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
                ingredientlist = ingredientRepo.GetAll();
                foreach(Ingrediënt i in ingredientlist)
                {
                    lbGetAll.Items.Add(i.ToString());
                }
            }
            else if (this.soort == "Product")
            {
                lblGetAll.Text = "Alle Producten";
                productlist = productRepo.GetAll();
                foreach(Product p in productlist)
                {
                    lbGetAll.Items.Add(p.ToString());
                }
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }
    }
}
