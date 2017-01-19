using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;
using Pizzeria.Database.Repositories;
using System.Data.SqlClient;

namespace Pizzeria.Database.MSSQL
{
    public class MSSQLPizzaContext : IPizzaContext
    {
        public SqlConnection connect { get; set; }
        public SqlCommand command { get; set; }

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
        public void CloseConnection()
        {
            connect.Close();
        }

        public List<Pizza> GetStandardPizza()
        {
            List<Pizza> pizzalist = new List<Pizza>();
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select * from pizza where standaard = 'Ja'",connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Vorm vorm = (Vorm)Enum.Parse(typeof(Vorm), Convert.ToString(reader["vorm"]));
                        Bodem bodem = (Bodem)Enum.Parse(typeof(Bodem), Convert.ToString(reader["bodem"]));
                        pizzalist.Add(new Pizza(Convert.ToString(reader["naam"]), vorm, bodem, Convert.ToString(reader["oppervlakte"]), true));
                    }
                }
                return pizzalist;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return pizzalist;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
