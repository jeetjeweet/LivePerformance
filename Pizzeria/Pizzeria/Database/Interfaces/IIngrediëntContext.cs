﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria.Database.Interfaces
{
    public interface IIngrediëntContext
    {
        SqlConnection connect { get; set; }
        SqlCommand command { get; set; }
        bool OpenConnection();
        void CloseConnection();
        List<Ingrediënt> GetAll();
        bool Edit(Ingrediënt ingredient,Ingrediënt nieuwingredient);
        bool Delete(Ingrediënt ingredient);
        bool AddIngrediënt(Ingrediënt ingrediënt);
        double GetID(Ingrediënt ingredient);
        double GetverkoopByID(int id);
    }
}
