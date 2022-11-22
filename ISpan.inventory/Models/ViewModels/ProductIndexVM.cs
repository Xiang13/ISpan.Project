using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.ViewModels
{
	public class ProductIndexVM
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }
		public string CustomerPhone { get; set; }
		public string DeliveryName { get; set; }
		public string DeliveryPhone { get; set; }
		public DateTime ArriveDate { get; set; }
		//public bool Delete { get; set; }
	}
}
