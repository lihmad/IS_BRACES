using IS_BRACES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace IS_BRACES.Models.ViewModels
{
    public class CompleteVacation
    {
        public string Destination { get; set; }
        private Guid DestinationId { get; set; }
        public int? NumberOfStar { get; set; }
        public string PopisUby { get; set; }
        public string TypeOfAcco { get; set; }
        private Guid UbytovaniId { get; set; }
        public List<SelectListItem> chooseList { get; set; }
        public string Image { get; set; }//base64
        public Guid Id { get; set; }

        public CompleteVacation(DB_Model db, Guid id)
        {
            UbytovaniId = db.Zajezdy.Find(id).Ubytovani.Id;
            DestinationId = db.Zajezdy.Find(id).Destinace.Id;
            Destination = GetCountryDB(db, id);
            TypeOfAcco = GetTypeOfAcco(db, id);
            NumberOfStar = GetNumberOfStar(db, id);
            PopisUby = GetPopisUby(db, id);
            chooseList = GetChooseList(UbytovaniId, DestinationId, db);
            var image = new ImageHelper();
            Image = image.GetTestBase64();
        }

        private string GetCountryDB(DB_Model DB, Guid id)
        {
            return DB.Zajezdy.Find(id).Destinace.Zeme.ToString();
        }

        private string GetTypeOfAcco(DB_Model DB, Guid id)
        {
            return DB.Zajezdy.Find(id).Ubytovani.TypUbytovani.Typ.ToString();
        }

        private int? GetNumberOfStar(DB_Model DB, Guid id)
        {
            return DB.Zajezdy.Find(id).Ubytovani.PocetHvezd;
        }

        private string GetPopisUby(DB_Model DB, Guid id)
        {
            
            return DB.Zajezdy.Find(id).Ubytovani.Popis;
        }

        private List<SelectListItem> GetChooseList(Guid idUbytovani, Guid idDestinace, DB_Model DB)
        {
            
            List<Zajezdy> zajezdyTest = DB.Zajezdy.Where(x => x.IdDestinace == idDestinace && x.IdUbytovani == idUbytovani).ToList();
            var l = new List<SelectListItem>();

            foreach (Zajezdy zajezd in zajezdyTest)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(zajezd.DatumOd);
                sb.Append(" - ");
                sb.Append(zajezd.DatumZruseni);
                sb.Append(" - ");
                sb.Append(zajezd.Stravovani.Typ);
                sb.Append(" - ");
                sb.Append(zajezd.Doprava.Type);
                sb.Append(" - ");
                sb.Append(zajezd.Cena);
                var i = new SelectListItem()
                {
                    Text = sb.ToString(),
                    Value = zajezd.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }
        


    }
}