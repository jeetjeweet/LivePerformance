using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Inkoop
    {
        public string naam { get; set; }
        public double inkoopprijs { get; set; }
        public double verkoopprijs { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="inkoopprijs"></param>
        /// <param name="verkoopprijs"></param>
        public Inkoop(string naam,double inkoopprijs,double verkoopprijs)
        {
            this.naam = naam;
            this.inkoopprijs = inkoopprijs;
            this.verkoopprijs = verkoopprijs;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
