using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS_BRACES.Models.ViewModels
{
    public class VacationSearch
    {
        [Display(Name = "Země")]
        public List<SelectListItem> CountryList { get; set; }
        [Display(Name = "Délka pobytu")]
        public List<SelectListItem> DurationList { get; set; }
        [Display(Name = "Úroveň hotelu")]
        public List<SelectListItem> HotelLevelList { get; set; }
        [Display(Name = "Strava")]
        public List<SelectListItem> FoodList { get; set; }
        [Display(Name = "Doprava")]
        public List<SelectListItem> TransportationList { get; set; }
        [Display(Name = "Typ zájezdu")]
        public List<SelectListItem> TypeList { get; set; }
        [Display(Name = "Nejdříve od", Prompt = "nejpozději od")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Nejpozději do", Prompt = "nejpozději do")]
        public DateTime DateTo { get; set; }

        public VacationSearch()
        {
            CountryList = GetCountry();
            DurationList = GetDuration();
            HotelLevelList = GetHotelLevel();
            FoodList = GetFood();
            TransportationList = GetTransportation();
            TypeList = GetType();
        }

        public VacationSearch(DB_Model db)
        {
            CountryList = GetCountryDB(db);
            DurationList = GetDuration();
            HotelLevelList = GetHotelLevel();
            FoodList = GetFoodDB(db);
            TransportationList = GetTransportationDB(db);
            TypeList = GetTypeDB(db);
        }

        private List<SelectListItem> GetCountryDB(DB_Model DB)
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


        private List<SelectListItem> GetFoodDB(DB_Model DB)
        {
            var l = new List<SelectListItem>();
            List<Stravovani> foodDB = DB.Stravovani.ToList();
            foreach (Stravovani food in foodDB)
            {
                var i = new SelectListItem()
                {
                    Text = food.Typ,
                    Value = food.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetTransportationDB(DB_Model DB)
        {
            var l = new List<SelectListItem>();
            List<Doprava> transportationDB = DB.Doprava.ToList();
            foreach (Doprava transportation in transportationDB)
            {
                var i = new SelectListItem()
                {
                    Text = transportation.Type,
                    Value = transportation.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }
        private List<SelectListItem> GetTypeDB(DB_Model DB)
        {
            var l = new List<SelectListItem>();
            List<TypZajezdu> typeDB = DB.TypZajezdu.ToList();
            foreach (TypZajezdu type in typeDB)
            {
                var i = new SelectListItem()
                {
                    Text = type.Popis,
                    Value = type.Id.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetCountry()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "Česká republika", "Chorvatsko", "Velká Británie", "USA", "Slovensko" };
            var c = 0;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetDuration()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "méně než 1 týden", "1 týden - 2 týdny", "více než 2 týdny" };
            var c = 0;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetHotelLevel()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "1 hvězda", "2 hvězdy", "3 hvězdy", "4 hvězdy", "5 hvězd" };
            var c = 1;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetFood()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "Snídaně", "Polopenze", "Plná penze", "All-Inclusive" };
            var c = 0;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }

        private List<SelectListItem> GetTransportation()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "Vlastní", "Autobusem", "Letecky" };
            var c = 0;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }
        private List<SelectListItem> GetType()
        {
            var l = new List<SelectListItem>();
            var f = new List<string>() { "Zimní dovolená", "Letní dovolená", "Poznávací dovolená", "Relaxační dovolená", "Vlastní dovolená" };
            var c = 0;
            foreach (string s in f)
            {
                var i = new SelectListItem()
                {
                    Text = s,
                    Value = c++.ToString()
                };
                l.Add(i);
            }
            return l;
        }

    }
}