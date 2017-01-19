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
    public class MSSQLProductContext : IProductContext
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

        public List<Product> GetAll()
        {
            List<Product> productlist = new List<Product>();
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select * from product", connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bool alcohol = false;
                        if(Convert.ToString(reader["Alcohol"]) == "Ja")
                        {
                            alcohol = true;
                        }
                        productlist.Add(new Product(Convert.ToString(reader["Naam"]), Convert.ToDouble(reader["Inkoop"]), Convert.ToDouble(reader["Verkoop"]), alcohol));
                    }
                }
                return productlist;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return productlist;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Edit(Product product,Product nieuwproduct)
        {
            int id = GetID(product);
            string alcohol = "";
            if (nieuwproduct.alcohol)
            {
                alcohol = "Ja";
            }
            else
            {
                alcohol = "Nee";
            }
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("update product set naam = '" + nieuwproduct.naam + "', inkoop = " + nieuwproduct.inkoopprijs + ", verkoop = " + nieuwproduct.verkoopprijs + ", alcohol = '" + alcohol + "' where id = " + id + ";", connect);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool Delete(Product product)
        {
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("delete from product where naam = '" + product.naam + "' and inkoop = " + product.inkoopprijs + ";", connect);
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

        public bool AddProduct(Product product)
        {
            string alcohol = "";
            if (product.alcohol == true)
            {
                alcohol = "Ja";
            }
            else
            {
                alcohol = "Nee";
            }
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("insert into product (naam,inkoop,verkoop,alcohol) values ('" + product.naam + "'," + product.inkoopprijs + ", " + product.verkoopprijs + ",'" + alcohol + "');", connect);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int GetID(Product product)
        {
            int ID = 0;
            try
            {
                if (OpenConnection())
                {
                    command = new SqlCommand("select id from product where naam = '" + product.naam + "' and inkoop = " + product.inkoopprijs + ";", connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ID = Convert.ToInt32(reader["id"]);
                    }
                }
                return ID;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return ID;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
