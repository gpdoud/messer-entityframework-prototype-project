using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Models {

	public class Customer {

		public int Id { get; set; }
		[StringLength(50)]
		[Required]
		public string Name { get; set; }
		public bool IsPreferred { get; set; } = true;
		public string Address { get; set; }

		public Customer() { }
	}
}
