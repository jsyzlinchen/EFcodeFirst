using EFcodeFirst.Helper;
using EFcodeFirst.Models;
using EFcodeFirst.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EFcodeFirst.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Contact()
        {

            return View();

       
        }


        public async Task<ActionResult> Save(string Name, string Phone, string Message, string Email)
        {
            var ctx = ContextHelper.Create();
            Contact u = new Contact();
            u.Name = Name;
            u.Phone = Phone;
            u.Email = Email;
            u.Message = Message;
            ctx.Contact.Add(u);
            await ctx.SaveChangesAsync();
            //return Json(new Success());
            return Content("<script >alert('提交留言成功，谢谢对我们支持，我们会根据您提供联系方式尽快与您取的联系！');window.history.go(-1);</script>");
        }


    }
}