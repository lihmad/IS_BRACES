using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS_BRACES.Controllers
{
    public class VacationController : Controller
    {
        // GET: Vacation
        public ActionResult Detail(Guid id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}