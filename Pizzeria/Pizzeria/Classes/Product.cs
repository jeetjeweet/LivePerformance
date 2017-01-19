using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Product : Inkoop
    {
        public bool alcohol { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="inkoopprijs"></param>
        /// <param name="verkoopprijs"></param>
        /// <param name="alcohol"></param>
        public Product(string naam, double inkoopprijs, double verkoopprijs,bool alcohol) : base(naam, inkoopprijs, verkoopprijs)
        {
            this.alcohol = alcohol;
        }

        public override string ToString()
        {
            return naam + " | " + inkoopprijs + " | " + verkoopprijs + " | " + alcohol;
        }
    }
}
