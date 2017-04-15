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
            return new VacationSearch(GetCountry(), GetDuration(), GetHotelLevel(), GetFood(), GetTransportation(), GetType());
        }

        private List<SelectListItem> GetCountry()
        {
            var l = new List<SelectListItem>();
            List<Destinace> destinationDB = DB.Destinace.ToList();
            foreach (Destinace desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.Zeme,
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetDuration()
        {
            var l = new List<SelectListItem>();
            List<Zajezdy> destinationDB = DB.Zajezdy.ToList();
            foreach (Zajezdy desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.DelkaPobytu + " dní",
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetHotelLevel()
        {
            var l = new List<SelectListItem>();
            List<TypUbytovani> destinationDB = DB.TypUbytovani.ToList();
            foreach (TypUbytovani desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.Typ,
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetFood()
        {
            var l = new List<SelectListItem>();
            List<Stravovani> destinationDB = DB.Stravovani.ToList();
            foreach (Stravovani desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.Typ,
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetTransportation()
        {
            var l = new List<SelectListItem>();
            List<Doprava> destinationDB = DB.Doprava.ToList();
            foreach (Doprava desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.Type,
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }
        private List<SelectListItem> GetType()
        {
            var l = new List<SelectListItem>();
            List<TypZajezdu> destinationDB = DB.TypZajezdu.ToList();
            foreach (TypZajezdu desti in destinationDB)
            {
                var i = new SelectListItem()
                {
                    Text = desti.Popis,
                    Value = desti.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

    }
}