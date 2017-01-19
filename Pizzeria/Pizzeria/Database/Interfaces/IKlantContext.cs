using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria.Database.Interfaces
{
    public interface IKlantContext
    {
        SqlConnection connect { get; set; }
        SqlCommand command { get; set; }
        bool OpenConnection();
        void CloseConnection();
    }
}
