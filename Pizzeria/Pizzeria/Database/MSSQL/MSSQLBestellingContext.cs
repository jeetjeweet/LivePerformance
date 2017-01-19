using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;
using Pizzeria.Database.Repositories;
using Pizzeria.Database;
using System.Data.SqlClient;

namespace Pizzeria.Database.MSSQL
{
    public class MSSQLBestellingContext : IBestellingContext
    {
        private PizzaRepository pizzaRepo = new PizzaRepository(new MSSQLPizzaContext());
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());
        private ProductRepository productRepo = new ProductRepository(new MSSQLProductContext());

        public SqlConnection connect { get; set; }
        public SqlCommand command { get; set; }
        /// <summary>
        /// voor het openen van een connectie met de database
        /// </summary>
        /// <returns></returns>
        public bool OpenConnection()
        {
            connect = new SqlConnection();

            try
            {
                connect.ConnectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi343862;User ID=dbi343862;Password=jedikkeoma";
                connect.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            if (connect.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// voor het sluiten van de connectie met de database
        /// </summary>
        public void CloseConnection()
        {
            connect.Close();
        }

        public bool NieuweBestelling(List<Pizza> pizzalist, List<Product> productlist)
        {
            return true;
            //double prijs = 0;
            //double btw = 0;
            //double totaalprijs = 0;
            //DateTime datum = DateTime.Now;
            //List<int> ingredientid = new List<int>();

            //try
            //{
            //    if (OpenConnection())
            //    {
            //        //krijg alle id's van ingredienten.
            //        foreach(Pizza p in pizzalist)
            //        {
            //            int id = pizzaRepo.GetID(p);
            //            List<int> idlist = pizzaRepo.GetIngredientIDByPizzaID(id);
            //            foreach(int i in idlist)
            //            {
            //                ingredientid.Add(i);
            //            }
            //        }
            //        //krijg totaalprijs van ingredienten
            //        foreach(int ids in ingredientid)
            //        {
            //            totaalprijs += ingredientRepo.GetverkoopByID(ids);
            //            btw += ingredientRepo.GetverkoopByID(ids) * 0.06;
            //            prijs += ingredientRepo.GetverkoopByID(ids) * 0.94;
            //        }
            //        Bestelling b = new Bestelling(prijs, totaalprijs, btw, datum);
            //        command = new SqlCommand("insert into bestelling (prijs,totaalprijs,btw,datum) values ("+b.+")", connect);
            //    }
            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    return false;
            //}
            //finally
            //{
            //    CloseConnection();
            //}
        }
    }
}
