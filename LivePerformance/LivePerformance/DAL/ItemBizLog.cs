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
    }
}
