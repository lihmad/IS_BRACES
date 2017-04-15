using IS_BRACES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace IS_BRACES.Controllers
{
    public class BaseApiController : ApiController
    {
        private DB_Model _db_Model;

        protected DB_Model DB
        {
            get
            {
                if (_db_Model == null)
                {
                    _db_Model = new DB_Model();
                }
                return (_db_Model);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_db_Model != null)
                {
                    _db_Model.Dispose();
                    _db_Model = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}