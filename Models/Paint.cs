using System;

namespace frontendapi_bikeshop.Models
{
     public class Paint
    {

        public int Paintid { get; set; }
        public string Colorname { get; set; }
        public string Colorstyle { get; set; }
        public string Colorlist { get; set; }
        public DateTime? Dateintroduced { get; set; }
        public DateTime? Datediscontinued { get; set; }

    }
}