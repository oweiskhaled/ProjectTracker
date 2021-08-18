using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.Models;

namespace YetAnotherResturant.DAL
{
    public interface IOrderDAL
    {
        public List<Order> GetORders();
    }
}
