using EFcodeFirst.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFcodeFirst.Controllers
{
    public class ValidateCodeController : Controller
    {
        // GET: ValidateCode
        public ActionResult Index()
        {
            int width = 138;
            int height = 32;
            int fontsize = 18;
            string code = string.Empty;
            byte[] bytes = ValidateCodeHelper.CreateValidateGraphic(out code, 4, width, height, fontsize);
            Session["VCode"] = code;
            return File(bytes, @"image/jpeg");
        }
    }
}