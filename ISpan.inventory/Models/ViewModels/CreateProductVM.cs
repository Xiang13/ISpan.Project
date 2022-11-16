using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.ViewModels
{
	internal class CreateProductVM
	{
		public string Supplier_Name { get; set; }
		public string Product_Name { get; set; }
		public int Unit_Price { get; set; }
		public int Quentity { get; set; }
		public int TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ArriveDate { get; set; }
	}
}
