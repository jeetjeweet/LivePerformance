using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria.Database
{
    public interface IPizzaContext
    {
        SqlConnection connect { get; set; }
        SqlCommand command { get; set; }
        bool OpenConnection();
        void CloseConnection();
        List<Pizza> GetStandardPizza();
        bool Edit(Pizza pizza);
        bool Delete(Pizza pizza);
        bool AddPizza(Pizza pizza,List<Ingrediënt> ingrediëntlist);
        int GetID(Pizza pizza);
        List<int> GetIngredientIDByPizzaID(int id);
    }
}
