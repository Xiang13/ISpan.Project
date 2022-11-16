using ISpan.inventory.Models.Services;
using ISpan.inventory.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory
{
	public partial class EditProductForm : Form
	{
		private int id;
		public EditProductForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = @"SELECT P.Product_Id, P.Product_Name, 
								  P.Unit_Price, P.Inventory, 
								  S.Supplier_Name, S.Supplier_Address, S.Supplier_Phone, 
								  O.ArriverDate
							FROM Products AS P
							JOIN Suppliers AS S ON P.Supplier_Id = S.Supplier_Id
							JOIN Orders AS O ON O.Product_Id = P.Product_Id";

			var parameters = new SqlParameterBuilder().AddInt("Product_Id", id).Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			InventoryIndexVM model = ParseToIndexVM(data.Rows[0]);
		}
		public InventoryIndexVM ParseToIndexVM(DataRow row)
		{
			return new InventoryIndexVM
			{
				Product_Id = row.Field<int>("Product_Id"),
				Product_Name = row.Field<string>("Product_Name"),
				Unit_Price = row.Field<int>("Unit_Price"),
				Inventory = row.Field<int>("Inventory"),
				Supplier_Name = row.Field<string>("Supplier_Name"),
				Supplier_Address = row.Field<string>("Supplier_Address"),
				Supplier_Phone = row.Field<string>("Supplier_Phone"),
				Order_Quantity = row.Field<int>("Order_Quantity"),
				ArriverDate = row.Field<DateTime>("ArriverDate")
			};
		}
	}
}
