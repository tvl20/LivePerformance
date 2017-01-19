using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    public interface IItemRepo
    {
        List<Ingredient> GetIngredienten();
        List<Pizza> GetPizzas();
        List<Salade> GetSalades();
        List<Drank> GetDranken();
        Pizza GetPizzaByID(int id);
        Salade GetSaladeByID(int id);
        Drank GetDrankByID(int id);
    }
}
