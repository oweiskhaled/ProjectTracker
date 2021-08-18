using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.Data;
using YetAnotherResturant.DTO.ItemDTO;
using YetAnotherResturant.Models;

namespace YetAnotherResturant.DAL
{
    public class ItemDAL : IItemDAL
    {
        private ApplicationDbContext context;
        public ItemDAL(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<Item> GetItems()
        {
            return context.Items.Include(x => x.Type).ToList();
        }

        public List<ItemSelectDTO> GetItems(int typeId)
        {
            return context.Items.Where(x => x.TypeId == typeId)
                .Select(x => new ItemSelectDTO { 
                    Id = x.Id,
                    Item = x.Name,
                    Price = x.Price
                }).ToList();
        }

        public List<ItemType> GetItemTypes()
        {
            return context.ItemTypes.ToList();
        }

        public void InsertItem(CreateItemDTO itemDTO)
        {
            Item item = new Item()
            {
                Name = itemDTO.Name,
                Description = itemDTO.Description,
                Price = itemDTO.Price,
                TypeId = itemDTO.TypeId
            };

            context.Items.Add(item);
            context.SaveChanges();
        }
    }
}
