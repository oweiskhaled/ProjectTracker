using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using YetAnotherResturant.DAL;
using YetAnotherResturant.DTO.ItemDTO;

namespace YetAnotherResturant.Controllers
{
    
    public class ItemController : Controller
    {
        private IItemDAL itemDAL;
        public ItemController(IItemDAL itemDAL)
        {
            this.itemDAL = itemDAL;
        }
        [Authorize(Roles ="ADMIN")]
        public IActionResult Items()
        {
            ViewBag.items = itemDAL.GetItems();
            return View();
        }
        public enum userRoles{
            ProjectManager = 1,
            TeamLeader = 2,
            Developer = 3
        }

        [HttpPost]
        public ActionResult SendEmail(string receiver, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("jamilmoughal786@gmail.com", "Jamil");
                    var receiverEmail = new MailAddress(receiver, "Receiver");
                    var password = "Your Email Password here";
                    var sub = subject;
                    var body = "<htm></html>";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    })
                    {
                        smtp.Send(mess);
                    }
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}
