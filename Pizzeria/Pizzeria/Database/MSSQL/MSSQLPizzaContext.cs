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
        private IngrediëntRepository ingredientRepo = new IngrediëntRepository(new MSSQLIngrediëntContext());
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

        public bool Edit(Pizza pizza)
        {
            try
            {
                if (OpenConnection())
                {

                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Delete(Pizza pizza)
        {
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("delete from pizza where naam= '" + pizza.naam + "' and bodem = '" + Convert.ToString(pizza.bodem) + "' and vorm = '" + Convert.ToString(pizza.vorm) + "' and oppervlakte ='" + pizza.oppervlakte + "' ;", connect);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool AddPizza(Pizza pizza,List<Ingrediënt> ingrediëntlist)
        {
            string standaard = "";
            if(pizza.standaard == true)
            {
                standaard = "Ja";
            }
            else
            {
                standaard = "Nee";
            }
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("insert into pizza (naam,vorm,bodem,oppervlakte,standaard) values ('" + pizza.naam + "','" + Convert.ToString(pizza.vorm) + "','" + Convert.ToString(pizza.bodem) + "','" + pizza.oppervlakte + "','" + standaard + "');", connect);
                    command.ExecuteNonQuery();
                }
                if (OpenConnection())
                {
                    int pizzaid = GetID(pizza);
                    List<double> ingredientidlist = new List<double>();
                    foreach(Ingrediënt ingredient in ingrediëntlist)
                    {
                        ingredientidlist.Add(ingredientRepo.GetID(ingredient));
                    }
                    foreach(double id in ingredientidlist)
                    {
                        if (OpenConnection())
                        {
                            command = new SqlCommand("insert into pizzaIngrediënt (pizzaid,ingrediëntid) values (" + pizzaid + ", " + id + ")", connect);
                            command.ExecuteNonQuery();
                        }
                    }
                   
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int GetID(Pizza pizza)
        {
            int id = 0;
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select id from pizza where naam = '"+pizza.naam+ "' and bodem = '" + Convert.ToString(pizza.bodem) + "' and vorm = '" + Convert.ToString(pizza.vorm) + "' and oppervlakte ='" + pizza.oppervlakte + "' ;", connect);
                    id = Convert.ToInt32(command.ExecuteScalar());
                }
                return id;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return id;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
