using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;

namespace Pizzeria.Database.Repositories
{
    public class PizzaRepository
    {
        private IPizzaContext pizzacontext;

        public PizzaRepository(IPizzaContext pizzacontext)
        {
            this.pizzacontext = pizzacontext;
        }

        public List<Pizza> GetStandardPizza()
        {
            return pizzacontext.GetStandardPizza();
        }
        public bool Edit(Pizza pizza)
        {
            return pizzacontext.Edit(pizza);
        }
        public bool Delete(Pizza pizza)
        {
            return pizzacontext.Delete(pizza);
        }
        public bool AddPizza(Pizza pizza,List<Ingrediënt> ingrediëntlist)
        {
            return pizzacontext.AddPizza(pizza,ingrediëntlist);
        }
        public int GetID(Pizza pizza)
        {
            return pizzacontext.GetID(pizza);
        }
        public List<int> GetIngredientIDByPizzaID(int id)
        {
            return pizzacontext.GetIngredientIDByPizzaID(id);
        }
    }
}
