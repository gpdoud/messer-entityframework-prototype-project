using EntityFrameworkConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Controllers {

	public class CustomersController {

		private AppDbContext db = new AppDbContext();

		public IEnumerable<Customer> List() {
			return db.Customers.Where(c => c.IsPreferred == false).ToList();
		}
	}
}
