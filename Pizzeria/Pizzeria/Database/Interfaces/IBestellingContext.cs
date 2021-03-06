﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria.Database.Interfaces
{
    public interface IBestellingContext
    {
        SqlConnection connect { get; set; }
        SqlCommand command { get; set; }
        bool OpenConnection();
        void CloseConnection();
        bool NieuweBestelling(List<Pizza> pizzalist,List<Product> productlist);
    }
}
