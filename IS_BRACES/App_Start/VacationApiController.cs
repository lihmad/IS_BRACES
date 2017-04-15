using IS_BRACES.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IS_BRACES.App_Start
{
    public class VacationApiController : ApiController
    {
        // GET api/<controller>
        public List<VacationThumbnail> Get()
        {
            var v = new VacationThumbnail();
            return v.GetDemo();
        }
    }
}