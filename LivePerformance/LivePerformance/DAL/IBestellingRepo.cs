using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    interface IBestellingRepo
    {
        void AddKlant(string naam, string adres);
        List<Klant> GetKlanten();
        List<Bestelling> GetBestellingen();
        void NewBestelling(Klant klant = null);
        void AddItem(int bestellingID, Item item);
    }
}
