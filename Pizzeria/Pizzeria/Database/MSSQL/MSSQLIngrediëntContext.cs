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
    public class MSSQLIngrediëntContext : IIngrediëntContext
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

        public List<Ingrediënt> GetAll()
        {
            List<Ingrediënt> ingredientlist = new List<Ingrediënt>();
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select * from ingrediënt", connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ingredientlist.Add(new Ingrediënt(Convert.ToString(reader["Naam"]),Convert.ToDouble(reader["Inkoop"]),Convert.ToDouble(reader["Verkoop"])));
                    }
                }
                return ingredientlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return ingredientlist;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Edit(Ingrediënt ingredient,Ingrediënt nieuwingredient)
        {
            double id = GetID(ingredient);
            string inkoop = Convert.ToString(nieuwingredient.inkoopprijs).Replace(",", ".");
            string verkoop = Convert.ToString(nieuwingredient.verkoopprijs).Replace(",", ".");
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("update ingrediënt set naam = '" + nieuwingredient.naam + "' , inkoop = " + inkoop + ", verkoop = " + verkoop + " where id = " + id + ";", connect);
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

        public bool Delete(Ingrediënt ingredient)
        {
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("delete from ingrediënt where naam = '" + ingredient.naam + "' and inkoop = " + ingredient.inkoopprijs + ";", connect);
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

        public bool AddIngrediënt(Ingrediënt ingrediënt)
        {
            string inkoop = Convert.ToString(ingrediënt.inkoopprijs).Replace(",",".");
            string verkoop = Convert.ToString(ingrediënt.verkoopprijs).Replace(",",".");
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("insert into ingrediënt (naam,inkoop,verkoop) values ('" + ingrediënt.naam + "'," + inkoop + "," + verkoop + ");", connect);
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

        public double GetID(Ingrediënt ingredient)
        {
            double id = 0;
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select id from ingrediënt where naam = '" + ingredient.naam + "';", connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToDouble(reader["ID"]);
                    }
                }
                return id;
            }
            catch (Exception ex)
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
