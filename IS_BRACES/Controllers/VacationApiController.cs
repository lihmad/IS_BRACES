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
        // GET api/<controller>
        public List<VacationThumbnail> Get()
        {
            var v = new VacationThumbnail();
            return v.GetDemo();
        }

        public List<VacationThumbnail> GetSpecificNumbersOfHotels(int numberOfHotels)
        {
            List<VacationThumbnail> randomVaca = new List<VacationThumbnail>();

            List<Zajezdy> test = DB.Zajezdy.OrderBy(r => Guid.NewGuid()).Take(numberOfHotels).ToList();

            foreach (Zajezdy zajezd in test)
            {
                var t = new VacationThumbnail()
                {

                };
                randomVaca.Add(t);

            }

            return randomVaca;
        }

    }
}