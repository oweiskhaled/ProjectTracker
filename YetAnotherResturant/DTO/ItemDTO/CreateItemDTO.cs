using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YetAnotherResturant.DTO.ItemDTO
{
    public class CreateItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TypeId { get; set; }
        public string Note { get; set; }
    }
}
