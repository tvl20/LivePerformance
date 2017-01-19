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

        public Drank(string naam, int inkoopPrijs, int verkoopPrijs, bool alcohol, int id)
        {
            Naam = naam;
            InkoopPrijs = inkoopPrijs;
            VerkoopPrijs = verkoopPrijs;
            Alcohol = alcohol;
            ID = id;
        }

        public override string ToString()
        {
            string str = Alcohol ? "ja" : "nee";
            return Naam + ", bevat alcohol: " + (str) + ", " + Convert.ToString(VerkoopPrijs);
        }
    }
}
