using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    public class ItemMSSQLrepo : IItemRepo
    {
        private string conn = "Data Source=DESKTOP-9K8HK1F;Initial Catalog=LivePerformance;Integrated Security=True";
        public List<Ingredienten> GetIngredienten()
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetPizzas()
        {
            throw new NotImplementedException();
        }

        public Pizza GetPizza(string naam)
        {
            throw new NotImplementedException();
        }

        public List<Salade> GetSalades()
        {
            throw new NotImplementedException();
        }

        public Salade GetSalade(string naam)
        {
            throw new NotImplementedException();
        }

        public List<Drank> GetDranken()
        {
            throw new NotImplementedException();
        }

        public Drank GetDrank(string naam)
        {
            throw new NotImplementedException();
        }
    }
}
