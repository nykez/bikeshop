using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using frontendapi_bikeshop.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace frontendapi_bikeshop {
	public class StateContainer {
		[Required]
		public ICollection<Bicycle> CartBikes { get; set; } = new List<Bicycle>();
		public Action OnChange;
		public void SetProperty(ICollection<Bicycle> cartBikes) {
			CartBikes = cartBikes;
			NotifyStateChanged();
		}

		public void AddBicycle(Bicycle bicycle) {
			CartBikes.Add(bicycle);
			NotifyStateChanged();
		}

		public void RemoveBicycle(Bicycle bicycle) {
			CartBikes.Remove(bicycle);
			NotifyStateChanged();
		}
		private void NotifyStateChanged() => OnChange?.Invoke();
	}
}
