using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YetAnotherResturant.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ItemType Type { get; set; }
        public int TypeId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
