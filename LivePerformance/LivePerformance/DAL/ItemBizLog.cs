using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    class ItemBizLog
    {
        private IItemRepo repo;

        public ItemBizLog(IItemRepo repo)
        {
            this.repo = repo;
        }

        public List<Ingredient> GetIngredienten()
        {
            return repo.GetIngredienten();
        }

        public List<Pizza> GetPizzas()
        {
            return repo.GetPizzas();
        }

        public List<Drank> GetDranken()
        {
            return repo.GetDranken();
        }

        public List<Salade> GetSalades()
        {
            return repo.GetSalades();
        }
    }
}
