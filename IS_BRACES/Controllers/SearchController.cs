using IS_BRACES.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS_BRACES.Controllers
{
    public class SearchController : BaseController
    {
        // GET: Search
        [HttpGet]
        public ActionResult FindQuick(string find, string datet, string datef)
        {

            return RedirectToAction("Find", new {vacation = new VacationSearch() });
        }

        [HttpGet]
        public ActionResult Find(VacationSearch vacation)
        {
            VacationThumbnail vt = new VacationThumbnail();
            
            return View(vt.GetDemo());
        }
    }
}