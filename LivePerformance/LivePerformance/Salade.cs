using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Salade : Item
    {
        public Salade(string naam, int inkoopPrijs, int verkoopPrijs)
        {
            Naam = naam;
            InkoopPrijs = inkoopPrijs;
            VerkoopPrijs = verkoopPrijs;
        }
    }
}
