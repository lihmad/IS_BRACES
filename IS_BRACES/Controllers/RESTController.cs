using IS_BRACES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace IS_BRACES.Controllers
{
    public class RESTController : BaseOdataController
    {
        [EnableQuery]
        public IQueryable<Zajezdy> Get() {
            return DB.Zajezdy.AsQueryable();
        }
    }
}