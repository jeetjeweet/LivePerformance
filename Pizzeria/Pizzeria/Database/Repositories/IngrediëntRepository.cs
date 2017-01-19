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
    }
}
