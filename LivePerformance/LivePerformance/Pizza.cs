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
        public int ID { get; private set; }
        public string Bodem { get; set; }
        public string Vorm { get; set; }
        public int Prijs { get; set; }

        public Pizza(int id)
        {
            ID = id;
        }
    }
}
