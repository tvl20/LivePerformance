using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DAL
{
    public interface IItemRepo
    {
        List<Ingredienten> GetIngredienten();
        List<Pizza> GetPizzas();
        Pizza GetPizza(string naam);
        List<Salade> GetSalades();
        Salade GetSalade(string naam);
        List<Drank> GetDranken();
        Drank GetDrank(string naam);
    }
}
