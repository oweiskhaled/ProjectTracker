using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.DTO.ItemDTO;
using YetAnotherResturant.Models;

namespace YetAnotherResturant.DAL
{
    public interface IItemDAL
    {
        public List<Item> GetItems();
        public List<ItemType> GetItemTypes();
        public void InsertItem(CreateItemDTO itemDTO);
        public List<ItemSelectDTO> GetItems(int typeId);
    }
}
