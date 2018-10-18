﻿using EntityFrameworkConsole.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole {

	class Program {

		static void Main(string[] args) {
			var cust = new CustomersController();
			var custs = cust.List();
			foreach(var c in custs) {
				Console.WriteLine($"{c.Id} | {c.Name} | {c.IsPreferred}");
			}
		}
	}
}
