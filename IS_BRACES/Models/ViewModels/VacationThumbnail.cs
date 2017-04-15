using IS_BRACES.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IS_BRACES.Models.ViewModels
{
    public class VacationThumbnail
    {
        public string Destination { get; set; }
        public string Hotel { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Transportation { get; set; }
        public string Food { get; set; }
        public string Image { get; set; }//base64

        public List<VacationThumbnail> GetDemo(int num = 8) {

            var list = new List<VacationThumbnail>();
            var image = new ImageHelper();
            for (var i = 0; i < num; i++) {
                var v = new VacationThumbnail()
                {
                    Destination = "Praha",
                    Hotel = "Hotel Pyramida",
                    DateFrom = DateTime.Now,
                    DateTo = DateTime.Now.AddDays(8),
                    Transportation = "Vlastní",
                    Food = "All-Inclusive",
                    Image = image.GetTestBase64()
                };
                list.Add(v);
            }


            return list;
        }
    }

}