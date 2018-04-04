using MVC.NET_Application.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.NET_Application.Controllers
{
    [Log]
    // [Authorize]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {         
            var message = Server.HtmlEncode(name);
            ViewBag.Message = message;
            return View();
        }
    }
}