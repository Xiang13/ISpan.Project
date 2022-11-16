using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.ViewModels
{
	internal class InventoryIndexVM
	{
		public int Product_Id { get; set; }
		public string Product_Name { get; set; }
		public int Unit_Price { get; set; }
		public int Inventory { get; set; }
		public string Supplier_Name { get; set; }
		public string Supplier_Address { get; set; }
		public string Supplier_Phone { get; set; }
		public int Order_Quantity { get; set; }
		public DateTime ArriverDate { get; set; }
	}
}
