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
            var predicate = PredicateBuilder.True<Zajezdy>();
            if (!string.IsNullOrEmpty(datef)) {
                DateTime from;
                if (DateTime.TryParse(datef, out from))
                {
                    predicate = predicate.And(i => i.DatumOd >= from);
                }
            }

            if (!string.IsNullOrEmpty(datet))
            {
                DateTime to;
                if (DateTime.TryParse(datet, out to))
                {
                    to = to.AddHours(24);
                    predicate = predicate.And(i => System.Data.Entity.DbFunctions.AddDays(i.DatumOd, i.DelkaPobytu) < to);
                }
            }

            if (!string.IsNullOrEmpty(find)) {
                var inner = PredicateBuilder.False<Zajezdy>();
                inner = inner.Or(i => i.Destinace.Zeme.Contains(find));
                inner = inner.Or(i => i.Popis.Contains(find));
                inner = inner.Or(i => i.Ubytovani.Nazev.Contains(find));
                predicate = predicate.And(inner);
            }

            var zajezdy = DB.Zajezdy.Where(predicate);



            List<VacationThumbnail> vts = new List<VacationThumbnail>();
            ImageHelper ih = new ImageHelper();
            foreach (var zajezd in zajezdy)
            {
                VacationThumbnail vt = new VacationThumbnail()
                {
                    Id = zajezd.Id,
                    Destination = zajezd.Destinace.Zeme + ", " + zajezd.Ubytovani.Adresa.Mesto,
                    Hotel = zajezd.Ubytovani.Nazev,
                    Stars = zajezd.Ubytovani.PocetHvezd.HasValue ? zajezd.Ubytovani.PocetHvezd.Value : 0,
                    DateFrom = zajezd.DatumOd,
                    DateTo = zajezd.DatumOd.AddDays(zajezd.DelkaPobytu),
                    Transportation = zajezd.Doprava.Type,
                    Food = zajezd.Stravovani.Typ,
                    Image = zajezd.Ubytovani.Prilohy.Select(z => z.Priloha).FirstOrDefault(),
                    Price = zajezd.Cena
                };
                vts.Add(vt);
            }

            ViewBag.Thumbnails = vts;

            return View("Find", new VacationSearch(DB));
        }

        [HttpGet]
        public ActionResult Find(VacationSearch vacation)
        {
            var vac = new VacationSearch(DB);

            var predicate = PredicateBuilder.True<Zajezdy>();

            if (vacation.Countries != null && vacation.Countries.Any()) { 
                predicate = predicate.And(i => vacation.Countries.Contains(i.Destinace.Id.ToString()));
                var sel = vac.CountryList.Where(x => vacation.Countries.Contains(x.Value));

                foreach (var s in sel) {
                    var r = vac.CountryList.First(x => x.Value == s.Value);
                    r.Selected = true;
                    
                }

                var kk = vac.CountryList.Where(x => x.Selected == true);

                if (kk.Count() > 0) {
                    List<string> sss = new List<string>();
                    foreach(var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Countries = sss.ToArray();
                }
            }

            if (vacation.Foods != null && vacation.Foods.Any()) {
                predicate = predicate.And(i => vacation.Foods.Contains(i.Stravovani.Id.ToString()));

                var sel = vac.FoodList.Where(x => vacation.Foods.Contains(x.Value));

                foreach (var s in sel)
                {
                    var r = vac.FoodList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.FoodList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Foods = sss.ToArray();
                }
            }


            if (vacation.Transportations != null && vacation.Transportations.Any()) {
                predicate = predicate.And(i => vacation.Transportations.Contains(i.Doprava.Id.ToString()));

                var sel = vac.TransportationList.Where(x => vacation.Transportations.Contains(x.Value));

                foreach (var s in sel)
                {
                    var r = vac.TransportationList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.TransportationList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Transportations = sss.ToArray();
                }
            }


            if (vacation.Types != null && vacation.Types.Any()) {
                predicate = predicate.And(i => i.VazTZajezdTypZajezdu.Any(z => vacation.Types.Contains(z.IdTypZajezdu.ToString())));

                var sel = vac.TypeList.Where(z => vacation.Types.Contains(z.Value));
                foreach (var s in sel)
                {
                    var r = vac.TypeList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.TypeList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Types = sss.ToArray();
                }

            }


            if (vacation.HotelLevels != null && vacation.HotelLevels.Any()) {
                predicate = predicate.And(i => vacation.HotelLevels.Contains(i.Ubytovani.PocetHvezd.ToString()));

                var sel = vac.HotelLevelList.Where(x => vacation.HotelLevels.Contains(x.Value));

                foreach (var s in sel)
                {
                    var r = vac.HotelLevelList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.HotelLevelList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.HotelLevels = sss.ToArray();
                }
            }
                

            if (!string.IsNullOrEmpty(vacation.From)) {
                DateTime from;
                if (DateTime.TryParse(vacation.From, out from)){
                    predicate = predicate.And(i => i.DatumOd >= from);
                }
            }

            if (!string.IsNullOrEmpty(vacation.To))
            {
                DateTime to;
                if (DateTime.TryParse(vacation.To, out to))
                {
                    to = to.AddHours(24);
                    predicate = predicate.And(i => System.Data.Entity.DbFunctions.AddDays(i.DatumOd, i.DelkaPobytu) < to);
                }
            }
            
                


            if (vacation.Durations != null && vacation.Durations.Any())
            {
                var inner = PredicateBuilder.False<Zajezdy>();
                
                foreach (string duration in vacation.Durations)
                {
                    
                    int id;
                    if (int.TryParse(duration, out id))
                    {
                        if (id == 0)
                        {
                            inner = inner.Or(i => i.DelkaPobytu < 7);
                        }
                        else if (id == 1)
                        {
                            inner = inner.Or(i => i.DelkaPobytu >= 7 && i.DelkaPobytu <= 14);
                        }
                        else if (id == 2)
                        {
                            inner = inner.Or(i => i.DelkaPobytu > 14);
                        }

                    }

                    
                }


                var sel = vac.DurationList.Where(x => vacation.Durations.Contains(x.Value));

                foreach (var s in sel)
                {
                    var r = vac.DurationList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.DurationList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Durations = sss.ToArray();
                }

                predicate = predicate.And(inner);
            }

            if (vacation.Prices != null && vacation.Prices.Any())
            {
                var inner = PredicateBuilder.False<Zajezdy>();
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
                            inner = inner.Or(i => i.Cena >= 70000);
                        }

                    }
                }

                var sel = vac.PriceList.Where(x => vacation.Prices.Contains(x.Value));

                foreach (var s in sel)
                {
                    var r = vac.PriceList.First(x => x.Value == s.Value);
                    r.Selected = true;

                }

                var kk = vac.PriceList.Where(x => x.Selected == true);

                if (kk.Count() > 0)
                {
                    List<string> sss = new List<string>();
                    foreach (var kkk in kk)
                    {
                        sss.Add(kkk.Value);
                    }
                    vac.Prices = sss.ToArray();
                }

                predicate = predicate.And(inner);
            }



            var zajezdy = DB.Zajezdy.Where(predicate);



            List<VacationThumbnail> vts = new List<VacationThumbnail>();
            ImageHelper ih = new ImageHelper();
            foreach (var zajezd in zajezdy) {
                VacationThumbnail vt = new VacationThumbnail() {
                    Id = zajezd.Id,
                    Destination = zajezd.Destinace.Zeme + ", " + zajezd.Ubytovani.Adresa.Mesto,
                    Hotel = zajezd.Ubytovani.Nazev,
                    Stars = zajezd.Ubytovani.PocetHvezd.HasValue ? zajezd.Ubytovani.PocetHvezd.Value : 0,
                    DateFrom = zajezd.DatumOd,
                    DateTo = zajezd.DatumOd.AddDays(zajezd.DelkaPobytu),
                    Transportation = zajezd.Doprava.Type,
                    Food = zajezd.Stravovani.Typ,
                    Image = zajezd.Ubytovani.Prilohy.Select(z => z.Priloha).FirstOrDefault(),
                    Price = zajezd.Cena
                };
                vts.Add(vt);
            }

            ViewBag.Thumbnails = vts;

            return View(vac);
        }
    }
}