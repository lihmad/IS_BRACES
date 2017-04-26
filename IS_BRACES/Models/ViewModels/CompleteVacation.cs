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
        public List<string> TypZajezdu { get; set; }
        public string PopisUby { get; set; }
        public string TypeOfAcco { get; set; }
        private Guid UbytovaniId { get; set; }
        public List<SelectListItem> ChooseList { get; set; }
        public List<string> Image { get; set; }//base64
        public Guid Id { get; set; }
        public Zajezdy zaj { get; set; }

        public CompleteVacation(DB_Model db, Guid id)
        {
            Image = new List<string>();
            var zajezd = db.Zajezdy.Find(id);
            zaj = zajezd;
            var prilohy = zajezd.Ubytovani.Prilohy.Select(x => x.Priloha).ToList();
            if(prilohy.Any())
                Image.AddRange(prilohy);
            Destination = zajezd.Destinace.Zeme;
            TypZajezdu = zajezd.VazTZajezdTypZajezdu.Select(x => x.TypZajezdu.Popis).ToList();
            TypeOfAcco = zajezd.Ubytovani.TypUbytovani.Typ;
            NumberOfStar = zajezd.Ubytovani.PocetHvezd;
            PopisUby = zajezd.Ubytovani.Popis;
            ChooseList = GetChooseList(zajezd.Ubytovani.Id, zajezd.Destinace.Id, db);
        }

        private List<SelectListItem> GetChooseList(Guid idUbytovani, Guid idDestinace, DB_Model DB)
        {
            
            List<Zajezdy> zajezdyTest = DB.Zajezdy.Where(x => x.IdDestinace == idDestinace && x.IdUbytovani == idUbytovani).ToList();
            var l = new List<SelectListItem>();

            foreach (Zajezdy zajezd in zajezdyTest)
            {
                //TODO: pridat pokoj z ubytovani
                //TODO: datum zruseni je na neco jineho pouzit delku pobytu
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