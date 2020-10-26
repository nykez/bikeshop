using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace frontendapi_bikeshop.Models
{
    public class Bicycle : IEquatable<Bicycle>
    {
        [Required]
        public int Serialnumber { get; set; }
        [Required]
        public int? Customerid { get; set; }
        [Required]
        public string Modeltype { get; set; }
        [Required]
        public int? Paintid { get; set; }
        [Required]
        public int? Framesize { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ShipDate { get; set; }
        [Required]
        public int? Shipemployee { get; set; }
        [Required]
        public int? Frameassembler { get; set; }
        [Required]
        public int? Painter { get; set; }
        [Required]
        public string Construction { get; set; }
        [Required]
        public int? Waterbottlebrazeons { get; set; }
        [Required]
        public string Customname { get; set; }
        [Required]
        public string Letterstyleid { get; set; }
        [Required]
        public int? Storeid { get; set; }
        [Required]
        public int? Employeeid { get; set; }
        [Required]
        public int? Toptube { get; set; }
        [Required]
        public int? Chainstay { get; set; }
        [Required]
        public int? Headtubeangle { get; set; }
        [Required]
        public int? Seattubeangle { get; set; }
        [Required]
        public int? Listprice { get; set; }
        [Required]
        public int? Saleprice { get; set; }
        [Required]
        public int? Salestax { get; set; }
        [Required]
        public string Salestate { get; set; }
        [Required]
        public int? Shipprice { get; set; }
        [Required]
        public int? Frameprice { get; set; }
        [Required]
        public int? Componentlist { get; set; }
        public Paint Paint { get; set; }


		public bool Equals(Bicycle other) {
            if(Serialnumber == other.Serialnumber) return true;
            return false;
		}
	}
}