using EFcodeFirst.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFcodeFirst.Models.Entities;

namespace EFcodeFirst.Controllers
{
    public class AccountController : Controller
    {
        // GET: 
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(int? TypeFlag, string UserName, string UserPassword)
        {
            UserName = UserName.Trim();
            UserPassword = UserPassword.Trim();
            //Code = Code.Trim().ToLower(); ;
            var ctx = ContextHelper.Create();
            var UserSession = AccountHelper.GetUser();
            var SysLog = new SysLog();
            var User = ctx.User.FirstOrDefault(x => x.UserName == UserName && x.DeleteFlag == false);
            if (User != null)
            {
                if (User.UserPassword == UserPassword)
                {
                    HttpContext.Application.Lock();
                    string SessionID = Session.SessionID;
                    string CurrentUser = "$Session_" + User.UserName;
                    //  HttpContext.Application.Add(CurrentUser,SessionID);
                    HttpContext.Application.Set(CurrentUser, SessionID);
                    HttpContext.Application.UnLock();
                    AccountHelper.SaveUser(User);
                    //if (Code == Session["VCode"].ToString().ToLower())
                    //{
                    //}
                    //else
                    //{
                    //    ViewBag.Message = "验证码输入错误！";
                    //    ViewBag.UserName = UserName.Trim();
                    //    ViewBag.UserPassword = UserPassword.Trim();
                    //    return View();
                    //}
                    if (User.TypeFlag == Enum.UserTypeFlag.外部)
                    {
                        User.LastTime = User.LogTime;
                        User.LogTime = DateTime.Now;
                        SysLog.Name = User.Name;
                        SysLog.Title = User.UserName;
                        SysLog.LogTime = DateTime.Now;
                        ctx.SysLog.Add(SysLog);
                        ctx.SaveChanges();

                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        User.LastTime = User.LogTime;
                        User.LogTime = DateTime.Now;
                        SysLog.Name = User.Name;
                        SysLog.Title = User.UserName;
                        SysLog.LogTime = DateTime.Now;
                        ctx.SysLog.Add(SysLog);
                        User.LastTime = User.LogTime;
                        User.LogTime = DateTime.Now;
                        ctx.SaveChanges();
                        return RedirectToAction("Index", "Home", new { Area = "Manage" });
                    }
                }
                else
                {
                    ViewBag.Message = "用户名或者密码错误！";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "用户名或者密码错误！";
                return View();
            }
        }
    }
}

