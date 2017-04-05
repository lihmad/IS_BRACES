using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS_BRACES.Models;

namespace IS_BRACES.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.G = DB.Destinace.First().Zeme;

            return View();
        }
    }
}
