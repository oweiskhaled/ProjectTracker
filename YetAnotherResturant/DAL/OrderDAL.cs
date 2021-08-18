using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.Data;
using YetAnotherResturant.Models;

namespace YetAnotherResturant.DAL
{
    public class OrderDAL : IOrderDAL
    {
        private ApplicationDbContext context; 
        public OrderDAL(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Order> GetORders()
        {
            return context.Orders.ToList();
        }
    }
}
