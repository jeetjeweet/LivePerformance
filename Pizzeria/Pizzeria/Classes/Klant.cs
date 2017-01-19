using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Klant
    {
        public string naam { get; set; }
        public string straat { get; set; }
        public string plaats { get; set; }
        public string huisnr { get; set; }
        public string postcode { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="straat"></param>
        /// <param name="plaats"></param>
        /// <param name="huisnr"></param>
        /// <param name="postcode"></param>
        public Klant(string naam,string straat,string plaats,string huisnr,string postcode)
        {
            this.naam = naam;
            this.straat = straat;
            this.plaats = plaats;
            this.huisnr = huisnr;
            this.postcode = postcode;
        }

        public override string ToString()
        {
            return naam + " | " + straat + " | " + plaats + " | " + huisnr + " | " + postcode;
        }
    }
}
