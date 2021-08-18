using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetAnotherResturant.DAL;
using System.Runtime.Serialization;
using System.Text.Json;

namespace YetAnotherResturant.Controllers
{

    public class OrderController : Controller
    {
        private IOrderDAL orderDAL;
        private IItemDAL itemDAL;
        public OrderController(IOrderDAL orderDAL, IItemDAL itemDAL)
        {
            this.orderDAL = orderDAL;
            this.itemDAL = itemDAL;
        }
        [Authorize]
        public IActionResult Orders()
        {
            ViewBag.orders = orderDAL.GetORders();
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.types = itemDAL.GetItemTypes();
            return View();
        }

        public string GetItems(int typeId)
        {
            var items = itemDAL.GetItems(typeId);
            return JsonSerializer.Serialize(items);
        }
    }
}
