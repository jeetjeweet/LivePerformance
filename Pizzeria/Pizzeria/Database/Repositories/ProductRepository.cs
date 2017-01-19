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
    }
}
