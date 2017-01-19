using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Ingrediënt : Inkoop
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="inkoopprijs"></param>
        /// <param name="verkoopprijs"></param>
        public Ingrediënt(string naam, double inkoopprijs, double verkoopprijs) : base(naam, inkoopprijs, verkoopprijs)
        {

        }

        public override string ToString()
        {
            return naam + " | " + inkoopprijs + " | " + verkoopprijs;
        }
    }
}
