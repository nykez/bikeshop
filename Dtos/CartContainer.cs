using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frontendapi_bikeshop {
	public class CartContainer {
		public int? CartTotal { get; set; } = 0;
		public int? BicycleTotal { get; set; } = 0;
		public int? BicycleSum { get; set; } = 0;
		public int? ComponentTotal { get; set; } = 0;
		public int? BicycleTax { get; set; } = 0;
	}
}
