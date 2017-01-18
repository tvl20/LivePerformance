using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LivePerformance
{
    class Bestelling
    {
        public int Prijs { get; set; }
        public int PrijsExBtw { get; set; }
        public int Btw { get; set; }

        public Klant Klant { get; set; }
        public Item Item { get; set; }
    }
}
