using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IS_BRACES.Models;
using IS_BRACES.Models.ViewModels;

namespace IS_BRACES.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //            return View(getVacationSearchFromDb());
            return View(new VacationSearch());
        }

        private VacationSearch getVacationSearchFromDb()
        {
            return new VacationSearch(DB);
        }



    }
}