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
    public partial class EditProduct : Form
    {
        private ProductRepository productRepo = new ProductRepository(new MSSQLProductContext());
        private Product product;
        public EditProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void btnEditProductOpslaan_Click(object sender, EventArgs e)
        {
            if (tbEditProductInkoop.Text == "" || tbEditProductNaam.Text == "" || tbEditProductVerkoop.Text == "" || cbEditProductAlcohol.SelectedItem == null)
            {
                MessageBox.Show("Een van de velden is leeg gelaten, vul deze alsnog in.");
            }
            else
            {
                bool alcohol = false;
                if (cbEditProductAlcohol.SelectedText == "Ja")
                {
                    alcohol = true;
                }
                else if (cbEditProductAlcohol.SelectedText == "Nee")
                {
                    alcohol = false;
                }
                Product nieuwproduct = new Product(tbEditProductNaam.Text, Convert.ToDouble(tbEditProductInkoop.Text), Convert.ToDouble(tbEditProductVerkoop.Text), alcohol);
                if (productRepo.Edit(this.product, nieuwproduct))
                {
                    MessageBox.Show("Het product is juist gewijzigd.");
                    GetAll ga = new GetAll("Product");
                    this.Close();
                    ga.Show();
                }
                else
                {
                    MessageBox.Show("Er is wat mis gegaan met het wijzigen van het product, probeer het opnieuw.");
                }
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            tbEditProductNaam.Text = product.naam;
            tbEditProductInkoop.Text = Convert.ToString(product.inkoopprijs);
            tbEditProductVerkoop.Text = Convert.ToString(product.verkoopprijs);
            if (product.alcohol)
            {
                cbEditProductAlcohol.SelectedItem = "Ja";
            }
            else
            {
                cbEditProductAlcohol.SelectedItem = "Nee";
            }
            
        }
    }
}
