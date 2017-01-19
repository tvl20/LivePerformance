using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    class BestellingBizLog
    {
        private IBestellingRepo repo;
        public BestellingBizLog(IBestellingRepo repo)
        {
            this.repo = repo;
        }

        public void NewKlant(string naam, string adres)
        {
            repo.AddKlant(naam, adres);
        }

        public List<Bestelling> GetBestellingen()
        {
            return repo.GetBestellingen();
        }

        public void NewBestelling(Klant klant = null)
        {
            Klant k = klant;
            repo.NewBestelling(klant);
        }

        public List<Klant> GetKlanten()
        {
            return repo.GetKlanten();
        }
    }
}
