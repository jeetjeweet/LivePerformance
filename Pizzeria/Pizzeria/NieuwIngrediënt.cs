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
    public partial class NieuwIngrediënt : Form
    {
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());
        public NieuwIngrediënt()
        {
            InitializeComponent();
        }

        private void btnNieuwIngrediëntOpslaan_Click(object sender, EventArgs e)
        {
            if(tbNieuwIngrediëntInkoop.Text == "" || tbNieuwIngrediëntNaam.Text == "" || tbNieuwIngrediëntVerkoop.Text == "")
            {
                MessageBox.Show("Een van de velden is leeg gelaten, vul deze alsnog in.");
            }
            else
            {
                Ingrediënt ingredient = new Ingrediënt(tbNieuwIngrediëntNaam.Text, Convert.ToDouble(tbNieuwIngrediëntInkoop.Text), Convert.ToDouble(tbNieuwIngrediëntVerkoop.Text));
                if(ingredientRepo.AddIngrediënt(ingredient))
                {
                    MessageBox.Show("Er is een nieuw ingredient aangemaakt.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan met een nieuw ingrediënt aanmaken, probeer het opnieuw.");
                }
            }
        }

        private void NieuwIngrediënt_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetAll ga = new GetAll("Ingrediënt");
            ga.Show();
        }
    }
}
