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
    public partial class EditIngrediënt : Form
    {
        private Ingrediënt ingrediënt;
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());

        public EditIngrediënt(Ingrediënt ingrediënt)
        {
            InitializeComponent();
            this.ingrediënt = ingrediënt;
        }

        private void btnEditingrediëntOpslaan_Click(object sender, EventArgs e)
        {
            if (tbEditingrediëntInkoop.Text == "" || tbEditingrediëntNaam.Text == "" || tbEditingrediëntVerkoop.Text == "")
            {
                MessageBox.Show("Een van de velden is leeg gelaten, vul deze alsnog in.");
            }
            else
            {
                Ingrediënt nieuwingrediënt = new Ingrediënt(tbEditingrediëntNaam.Text, Convert.ToDouble(tbEditingrediëntInkoop.Text), Convert.ToDouble(tbEditingrediëntVerkoop.Text));
                if (ingredientRepo.Edit(ingrediënt, nieuwingrediënt))
                {
                    MessageBox.Show("Het ingrediënt is juist gewijzigd.");
                    GetAll ga = new GetAll("Ingrediënt");
                    this.Close();
                    ga.Show();
                }
                else
                {
                    MessageBox.Show("Er is wat mis gegaan met het wijzigen van het ingrediënt, probeer het opnieuw.");
                }
            }
        }

        /// <summary>
        /// vul de textboxen met de info van het ingrediënt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditIngrediënt_Load(object sender, EventArgs e)
        {
            tbEditingrediëntNaam.Text = ingrediënt.naam;
            tbEditingrediëntInkoop.Text = Convert.ToString(ingrediënt.inkoopprijs);
            tbEditingrediëntVerkoop.Text = Convert.ToString(ingrediënt.verkoopprijs);
        }
    }
}
