using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Pizza : Item
    {
        public List<Ingredient> Ingredienten { get; set; }
        public string Bodem { get; set; }
        public string Vorm { get; set; }
        public int Prijs { get; set; }
        public int Oppervlakte { get; set; }

        public Pizza(int id, int oppervlakte)
        {
            ID = id;
            Oppervlakte = oppervlakte;
        }
    }
}
