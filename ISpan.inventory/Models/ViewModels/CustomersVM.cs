using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.ViewModels
{
	public class CustomersIndexVM
	{
		// public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }
		public string CustomerPhone { get; set; }
	}

	public class CustomersVM
	{
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }
		public string CustomerPhone { get; set; }
	}
}
