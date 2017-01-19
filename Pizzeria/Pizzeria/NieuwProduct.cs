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
    public partial class NieuwProduct : Form
    {
        private ProductRepository productRepo = new ProductRepository(new MSSQLProductContext());
        public NieuwProduct()
        {
            InitializeComponent();
        }

        private void btnNieuwProductOpslaan_Click(object sender, EventArgs e)
        {
            if(tbNieuwProductInkoop.Text == "" || tbNieuwProductNaam.Text == "" || tbNieuwProductVerkoop.Text == "" || cbNieuwProductAlcohol.SelectedItem == null)
            {
                MessageBox.Show("Een van de velden is leeg gelaten, vul deze alsnog in.");
            }
            else
            {
                bool alcohol = false;
                if(cbNieuwProductAlcohol.SelectedText == "Ja")
                {
                    alcohol = true;
                }
                else if(cbNieuwProductAlcohol.SelectedText == "Nee")
                {
                    alcohol = false;
                }
                Product product = new Product(tbNieuwProductNaam.Text, Convert.ToDouble(tbNieuwProductInkoop.Text), Convert.ToDouble(tbNieuwProductVerkoop.Text), alcohol);
                if (productRepo.AddProduct(product))
                {
                    MessageBox.Show("Het nieuwe product is aangemaakt.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan met het aanmaken van het product, probeer het opnieuw");
                }
            }
        }

        private void NieuwProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetAll ga = new GetAll("Product");
            ga.Show();
        }
    }
}
