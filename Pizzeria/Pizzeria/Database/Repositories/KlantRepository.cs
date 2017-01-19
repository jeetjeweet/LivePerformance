using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Database.Interfaces;

namespace Pizzeria.Database.Repositories
{
    public class KlantRepository
    {
        private IKlantContext klantcontext;

        public KlantRepository(IKlantContext klantcontext)
        {
            this.klantcontext = klantcontext;
        }
    }
}
