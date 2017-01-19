using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Item
    {
        public string Naam { get; set; }
        public int InkoopPrijs { get; set; }
        public int VerkoopPrijs { get; set; }
        public int ID { get; set; }
    }
}
