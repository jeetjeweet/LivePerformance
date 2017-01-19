using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;

namespace Pizzeria.Database.Repositories
{
    public class ProductRepository
    {
        private IProductContext productcontext;

        public ProductRepository(IProductContext productcontext)
        {
            this.productcontext = productcontext;
        }
        public List<Product> GetAll()
        {
            return productcontext.GetAll();
        }
        public bool Edit(Product product,Product nieuwproduct)
        {
            return productcontext.Edit(product,nieuwproduct);
        }
        public bool Delete(Product product)
        {
            return productcontext.Delete(product);
        }
        public bool AddProduct(Product product)
        {
            return productcontext.AddProduct(product);
        }
    }
}
