using IS_BRACES.Models;
using IS_BRACES.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IS_BRACES.Controllers
{
    public class VacationApiController : BaseApiController
    {
        [HttpGet]
        public List<VacationThumbnail> Get([FromUri] int? numberOfHotels)
        {
            if (numberOfHotels.HasValue)
            {
                List<VacationThumbnail> randomVaca = new List<VacationThumbnail>();

                List<Zajezdy> test = DB.Zajezdy.OrderBy(r => Guid.NewGuid()).Take(numberOfHotels.Value).Distinct().ToList();

                foreach (Zajezdy zajezd in test)
                {
                    var t = new VacationThumbnail()
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
                    randomVaca.Add(t);

                }

                return randomVaca;
            }
            else {
                var v = new VacationThumbnail();
                return v.GetDemo();
            }

        }

    }
}