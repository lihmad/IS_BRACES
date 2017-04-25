using IS_BRACES.Helpers;
using IS_BRACES.Models;
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
            

            var predicate = PredicateBuilder.True<Zajezdy>();

            if (vacation.Countries != null && vacation.Countries.Any()) {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string country in vacation.Countries) {
                    Guid id;
                    if(Guid.TryParse(country, out id))
                        inner = inner.Or(i => i.Destinace.Id == id);
                }

                predicate = predicate.And(inner);
            }

            if (vacation.Foods != null && vacation.Foods.Any())
            {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string food in vacation.Foods)
                {
                    Guid id;
                    if (Guid.TryParse(food, out id))
                        inner = inner.Or(i => i.Stravovani.Id == id);
                }

                predicate = predicate.And(inner);
            }


            if (vacation.Transportations != null && vacation.Transportations.Any())
            {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string transport in vacation.Transportations)
                {
                    Guid id;
                    if (Guid.TryParse(transport, out id))
                        inner = inner.Or(i => i.Doprava.Id == id);
                }

                predicate = predicate.And(inner);
            }

            if (vacation.Types != null && vacation.Types.Any())
            {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string type in vacation.Types)
                {
                    Guid id;
                    if (Guid.TryParse(type, out id))
                        inner = inner.Or(i => i.Ubytovani.TypUbytovani.Id == id);
                }

                predicate = predicate.And(inner);
            }

            if (vacation.HotelLevels != null && vacation.HotelLevels.Any())
            {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string level in vacation.HotelLevels)
                {
                    int stars;
                    if (int.TryParse(level, out stars))
                        inner = inner.Or(i => i.Ubytovani.PocetHvezd == stars);
                }

                predicate = predicate.And(inner);
            }

            if (vacation.Durations != null && vacation.Durations.Any()) {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string duration in vacation.Durations)
                {
                    int id;
                    if (int.TryParse(duration, out id)) {
                        if (id == 0)
                        {
                            inner = inner.Or(i => i.DelkaPobytu < 7);
                        }
                        else if (id == 1)
                        {
                            inner = inner.Or(i => i.DelkaPobytu >= 7 && i.DelkaPobytu <= 14);
                        }
                        else if (id == 2) {
                            inner = inner.Or(i => i.DelkaPobytu > 14);
                        }

                    }
                }

                predicate = predicate.And(inner);
            }

            if (vacation.Prices != null && vacation.Prices.Any())
            {
                var inner = PredicateBuilder.True<Zajezdy>();
                foreach (string price in vacation.Prices)
                {
                    int id;
                    if (int.TryParse(price, out id))
                    {
                        if (id == 0)
                        {
                            inner = inner.Or(i => i.Cena < 10000);
                        }
                        else if (id == 1)
                        {
                            inner = inner.Or(i => i.Cena >= 10000 && i.Cena < 20000);
                        }
                        else if (id == 2)
                        {
                            inner = inner.Or(i => i.Cena >= 20000 && i.Cena < 40000);
                        }
                        else if (id == 3)
                        {
                            inner = inner.Or(i => i.Cena >= 40000 && i.Cena < 70000);
                        }
                        else if (id == 4)
                        {
                            inner = inner.Or(i => i.Cena >= 70000 );
                        }

                    }
                }

                predicate = predicate.And(inner);
            }


            var zajezdy = DB.Zajezdy.Where(predicate);



            List<VacationThumbnail> vts = new List<VacationThumbnail>();
            ImageHelper ih = new ImageHelper();
            foreach (var zajezd in zajezdy) {
                VacationThumbnail vt = new VacationThumbnail() {
                    DateFrom = zajezd.DatumOd,
                    DateTo = zajezd.DatumOd.AddDays(zajezd.DelkaPobytu),
                    Destination = zajezd.Destinace.Zeme,
                    Food = zajezd.Stravovani.Typ,
                    Hotel = zajezd.Ubytovani.Nazev,
                    Image = ih.GetTestBase64(),
                    Id = zajezd.Id,
                    Transportation = zajezd.Doprava.Type
                };
                vts.Add(vt);
            }
            return View(vts);
        }
    }
}