using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizza
    {
        public string naam { get; set; }
        public Vorm vorm { get; set; }
        public Bodem bodem { get; set; }
        public string oppervlakte { get; set; }
        public bool standaard { get; set; }
        public List<Ingrediënt> ingredientlist;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="vorm"></param>
        /// <param name="bodem"></param>
        /// <param name="oppervlakte"></param>
        /// <param name="standaard"></param>
        public Pizza(string naam,Vorm vorm,Bodem bodem,string oppervlakte,bool standaard)
        {
            this.naam = naam;
            this.vorm = vorm;
            this.bodem = bodem;
            this.oppervlakte = oppervlakte;
            this.standaard = standaard;
            ingredientlist = new List<Ingrediënt>();
        }

        public override string ToString()
        {
            return naam + " | " + vorm + " | " + bodem + " | " + oppervlakte + " | " + standaard;
        }
    }
}
