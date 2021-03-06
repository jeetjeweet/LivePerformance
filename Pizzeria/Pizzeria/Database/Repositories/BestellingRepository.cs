﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;

namespace Pizzeria.Database.Repositories
{
    public class BestellingRepository
    {
        private IBestellingContext bestellingcontext;

        public BestellingRepository(IBestellingContext bestellingcontext)
        {
            this.bestellingcontext = bestellingcontext;
        }
        public bool NieuweBestelling(List<Pizza> pizzalist, List<Product> productlist)
        {
            return bestellingcontext.NieuweBestelling(pizzalist,productlist);
        }
    }
}
