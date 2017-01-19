using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Bestelling
    {
        public double prijs { get; set; }
        public double totaalPrijs { get; set; }
        public double btw { get; set; }
        public DateTime datum { get; set; }


        public Bestelling(double prijs,double totaalprijs,double btw,DateTime datum)
        {
            this.prijs = prijs;
            this.totaalPrijs = totaalprijs;
            this.btw = btw;
            this.datum = datum;
        }
    }
}
