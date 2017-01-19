using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pizzeria.Database.Interfaces
{
    public interface IProductContext
    {
        SqlConnection connect { get; set; }
        SqlCommand command { get; set; }
        bool OpenConnection();
        void CloseConnection();
        List<Product> GetAll();
        bool Edit(Product product,Product nieuwproduct);
        bool Delete(Product product);
        bool AddProduct(Product product);
        int GetID(Product product);
    }
}
