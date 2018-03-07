using EFcodeFirst.Helper;
using EFcodeFirst.Models.Entities;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EFcodeFirst.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(string Name, string UserName, string UserPassword,string ConfirmPassword)
        {
            var ctx = ContextHelper.Create();           
            User u = new User();
            var query = ctx.User.AsQueryable();
            //query = query.FirstOrDefault(x => x.UserName==UserName);
            var model =  ctx.User.FirstOrDefault(x => x.UserName == UserName);
            if (String.IsNullOrEmpty(UserName))
            {
                return Content("<script >alert('用户名不能为空！');window.history.go(-1);</script>");
            }
            if (model != null)
            {
                return Content("<script >alert('用户名已存在！');window.history.go(-1);</script>");
            }
            else
            {
                u.Name = Name;
                u.UserName = UserName;
                u.UserPassword = UserPassword;
                u.ConfirmPassword = ConfirmPassword;
                u.CreatTime = DateTime.Now;
                u.LogTime = DateTime.Now;
                ctx.User.Add(u);
                ctx.SaveChangesAsync();
                //return Json(new Success());
                return Content("<script >alert('注册成功！');window.history.go(-1);</script>");
            }
           
        }


        public ActionResult Edit(string Name, string Phone,int Age,int Gender, )   //更新个人信息
        {
            var ctx = ContextHelper.Create();
            User u = new User();
            var query = ctx.User.AsQueryable();
            //query = query.FirstOrDefault(x => x.UserName==UserName);
            var model = ctx.User.FirstOrDefault(x => x.UserName == UserName);
           
                u.Name = Name;
                u.Phone = Phone;
                u.UserPassword = UserPassword;
                u.ConfirmPassword = ConfirmPassword;
                ctx.User.Add(u);
                ctx.SaveChangesAsync();
                //return Json(new Success());
                return Content("<script >alert('注册成功！');window.history.go(-1);</script>");
           


        }

}