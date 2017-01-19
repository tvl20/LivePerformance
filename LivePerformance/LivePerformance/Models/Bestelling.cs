using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LivePerformance
{
    public class Bestelling
    {
        public int ID { get; set; }
        public int Prijs { get; set; }
        public int PrijsExBtw { get; set; }
        public int Btw { get; set; }

        public Klant Klant { get; set; }
        public List<Item> Items { get; set; }

        public override string ToString()
        {
            if (Klant != null)
            {
                return Convert.ToString(ID) + " : " + Klant.Naam + " - " + Convert.ToString(Prijs);
            }
            else
            {
                return Convert.ToString(ID) + " : " + "No name specified - " + Convert.ToString(Prijs);
            }
        }
    }
}
