﻿using System;
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
    }
}
