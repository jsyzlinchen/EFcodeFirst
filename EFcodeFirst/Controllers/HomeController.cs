using EFcodeFirst.Helper;
using EFcodeFirst.Models;
using EFcodeFirst.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFcodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ////创建上下文
            //DataModel db = new DataModel();
            ////创建数据库
            //db.Database.CreateIfNotExists();
            ////创建表且将字段加入进去
            //Order or = new Order();
            //or.Context = "lin2";
            ////将表加入到数据库中
            //db.Order.Add(or);
            ////保存之
            //db.SaveChanges();
            //Console.WriteLine("成功创建数据库和表");
            //Console.ReadKey();

            return View();
        }

        public ActionResult Contact()
        {
            var ctx = ContextHelper.Create();
            ctx.Database.CreateIfNotExists();//创建数据库
            Contact  u = new Contact();
            u.Name="LLLL";
            ctx.Contact.Add(u);
            ctx.SaveChangesAsync();
            //return Json(new Success());
            return Content("<script >alert('提交留言成功，谢谢对我们支持，我们会根据您提供联系方式尽快与您取的联系！');window.history.go(-1);</script>");
        }


        
    }
}