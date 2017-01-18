using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Drank : Item
    {
        public bool Alcohol { get; set; }

        public Drank(string naam, int inkoopPrijs, int verkoopPrijs, bool alcohol)
        {
            Naam = naam;
            InkoopPrijs = inkoopPrijs;
            VerkoopPrijs = verkoopPrijs;
            Alcohol = alcohol;
        }
    }
}
