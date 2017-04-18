using IS_BRACES.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS_BRACES.Controllers
{
    public class VacationController : BaseController
    {
        // GET: Vacation
        public ActionResult Detail(Guid id)
        {
            CompleteVacation vaca = new CompleteVacation(DB, id);

            ViewBag.id = "123";
            return View();
        }
    }
}