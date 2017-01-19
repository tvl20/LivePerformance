using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Ingredient
    {
        public string Naam { get; set; }
        public int ID { get; set; }

        public Ingredient(string naam, int id)
        {
            Naam = naam;
            ID = id;
        }
    }
}
