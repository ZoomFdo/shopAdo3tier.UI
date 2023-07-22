using ShopAdo3tier.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdo3tier.DAL.Repositories
{
    public class GoodRepository : GenericRepository<Good>
    {
        public GoodRepository() : base(new ShopAdoContext())
        {

        }
    }
}
