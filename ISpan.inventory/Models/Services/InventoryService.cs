using ISpan.inventory.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory.Models.Services
{
	internal class InventoryService
	{
		/// <summary>
		/// 傳回所有使用者紀錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<InventoryIndexVM> GetAll()
		{
			string sql = @"SELECT P.Product_Id, P.Product_Name, 
								  P.Unit_Price, P.Inventory, 
								  S.Supplier_Name, S.Supplier_Address, S.Supplier_Phone,
								  O.Order_Quantity, O.ArriverDate
							FROM Products AS P
							JOIN Suppliers AS S ON P.Supplier_Id = S.Supplier_Id
							JOIN Orders AS O ON O.Product_Id = P.Product_Id";
			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
								.AsEnumerable()
								.Select(row => ParseToIndexVM(row));

		}
		public IEnumerable<SupplierVM> GetSupplier()
		{
			var sql = "SELECT * FROM Suppliers";
			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToSupplierVM(row))
				.Prepend(new SupplierVM { Supplier_Id = 0, Supplier_Name = String.Empty });
		}
		public IEnumerable<InventoryIndexVM> GetInitSupplier(int supplierId)
		{
			string sql = @"SELECT P.Product_Id, P.Product_Name, 
								  P.Unit_Price, P.Inventory, 
								  S.Supplier_Name, S.Supplier_Address, S.Supplier_Phone,
								  O.Order_Quantity, O.ArriverDate
							FROM Products AS P
							JOIN Suppliers AS S ON P.Supplier_Id = S.Supplier_Id
							JOIN Orders AS O ON O.Product_Id = P.Product_Id";

			SqlParameter[] parameters = new SqlParameter[] { };

			// 取得篩選值
			//int supplierId = ((SupplierVM)supplierComBox1.SelectedItem).Supplier_Id;

			if (supplierId > 0)
			{
				sql += " WHERE S.Supplier_Id=@Supplier_Id";
				parameters = new SqlParameterBuilder()
					.AddInt("Supplier_Id", supplierId)
					.Build();
			}
			//加入排序子句
			sql += " ORDER BY O.ArriverDate";
			var dbHelper = new SqlDbHelper("default");
			// 存放在 Field, 稍後在 grid CellClick 事件會需要再度用到它
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}
		public SupplierVM ToSupplierVM(DataRow row)
		{
			return new SupplierVM
			{
				Supplier_Id = row.Field<int>("Supplier_Id"),
				Supplier_Name = row.Field<string>("Supplier_Name"),
				Supplier_Address = row.Field<string>("Supplier_Address"),
				Supplier_Phone = row.Field<string>("Supplier_Phone"),
			};
		}
		public InventoryIndexVM ParseToIndexVM(DataRow row)
		{
			return new InventoryIndexVM
			{
				Product_Id = row.Field<int>("Product_Id"),
				Product_Name = row.Field<string>("Product_Name"),
				Unit_Price = row.Field<int>("Unit_Price"),
				Inventory = row.Field<int>("inventory"),
				Supplier_Name = row.Field<string>("Supplier_Name"),
				Supplier_Address = row.Field<string>("Supplier_Address"),
				Supplier_Phone = row.Field<string>("Supplier_Phone"),
				Order_Quantity = row.Field<int>("Order_Quantity"),
				ArriverDate = row.Field<DateTime>("ArriverDate")
			};
		}
		internal void Create(CreateProductVM model)
		{
			string sql = @"INSERT INTO Users (Account, Password, Name)
						VALUES(@Account, @Password, @Name)";
			var parameters = new SqlParameterBuilder().AddNVarchar("Supplier_Name", 50, model.Supplier_Name)
													  .AddNVarchar("Product_Name", 50, model.Product_Name)
													  .AddInt("Unit_Price", model.Unit_Price)
													  .AddInt("Quentity", model.Quentity)
													  .AddInt("TotalPrice", model.TotalPrice)
													  .AddDateTime("OrderDate", model.OrderDate)
													  .AddDateTime("ArriveDate", model.ArriveDate)
													  .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);	
		}
	}
}
