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
        BestellingRepository bestelRepo = new BestellingRepository(new MSSQLBestellingContext());

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
    }
}
