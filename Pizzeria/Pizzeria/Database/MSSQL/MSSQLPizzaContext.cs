using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;
using Pizzeria.Database.Repositories;

namespace Pizzeria.Database.MSSQL
{
    public class MSSQLPizzaContext : IPizzaContext
    {
        PizzaRepository pizzaRepo = new PizzaRepository(new MSSQLPizzaContext());
    }
}
