using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Klant
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }

        public Klant(string naam, string adres, int id)
        {
            Naam = naam;
            Adres = adres;
            ID = id;
        }

        public override string ToString()
        {
            return Naam + " - " + Adres;
        }
    }
}
