using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine

        public ActionResult Index()
        {
            return Content("This is the index page for cuisines");
        }

        [HttpGet]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }

        

    }
}