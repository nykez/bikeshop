using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using frontendapi_bikeshop.Models;

namespace frontendapi_bikeshop {
	public partial class StateContainer {
		public ICollection<Bicycle> CartBikes { get; } = new List<Bicycle>();
		public Action OnChange;
		public void SetProperty(String value) {
			
			NotifyStateChanged();
		}

		public void AddBicycle(Bicycle bicycle) {
			CartBikes.Add(bicycle);
			NotifyStateChanged();
		}
		private void NotifyStateChanged() => OnChange?.Invoke();
	}
}
