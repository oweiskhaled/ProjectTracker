using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.DTO.ItemDTO;

namespace YetAnotherResturant.DTO.OrderDTO
{
    public class CreateOrderDTO
    {
        public List<CreateItemDTO> Items { get; set; }
        public string CustomerId { get; set; }
        public string Address { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
