using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;

namespace Pizzeria.Database.Repositories
{
    public class IngrediëntRepository
    {
        private IIngrediëntContext ingredientcontext;

        public IngrediëntRepository(IIngrediëntContext ingredientcontext)
        {
            this.ingredientcontext = ingredientcontext;
        }

        public List<Ingrediënt> GetAll()
        {
            return ingredientcontext.GetAll();
        }
        public bool Edit(Ingrediënt ingredient)
        {
            return ingredientcontext.Edit(ingredient);
        }
        public bool Delete(Ingrediënt ingredient)
        {
            return ingredientcontext.Delete(ingredient);
        }
        public bool AddIngrediënt(Ingrediënt ingrediënt)
        {
            return ingredientcontext.AddIngrediënt(ingrediënt);
        }
        public double GetID(Ingrediënt ingredient)
        {
            return ingredientcontext.GetID(ingredient);
        }
    }
}
