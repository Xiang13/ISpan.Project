using ISpan.inventory.Models.DTOs;
using ISpan.inventory.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory.Infra.DAOs
{
	internal class ProductDAO
	{
		public IEnumerable<ProductDTO> GetAll(int deliveryId, int customerId)
		{
			string sql = @"SELECT P.productId, P.ProductName, C.customerName, C.customerAddress, C.customerPhone,
								  D.deliveryName, D.deliveryPhone, P.arriveDate
							FROM deliveries as D
							JOIN products AS P ON D.deliveryId = P.deliveryId
							JOIN customers AS C ON C.customerId = P.customerId";
			SqlParameter[] parameters = new SqlParameter[] { };

			if (deliveryId > 0 && customerId > 0)
			{
				sql += " WHERE P.deliveryId=@deliveryId and C.customerId=@customerId";
				parameters = new SqlParameterBuilder()
					.AddInt("deliveryId", deliveryId)
					.AddInt("customerId", customerId)
					.Build();
			}
			else if(deliveryId > 0)
			{
				sql += " WHERE P.deliveryId=@deliveryId";
				parameters = new SqlParameterBuilder()
					.AddInt("deliveryId", deliveryId)
					.Build();
			}
			else if(customerId > 0)
			{
				sql += " WHERE P.customerId=@customerId";
				parameters = new SqlParameterBuilder()
					.AddInt("customerId", customerId)
					.Build();
			}
			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row =>  ToProductDTO(row));
		}

		public void CreateCustomer(CreateCustomerVM model)
		{
			string sql = @"INSERT INTO customers (customerName, customerAddress, customerPhone)
						VALUES(@customerName, @customerAddress, @customerPhone)";
			var parameters = new SqlParameterBuilder().AddNVarchar("customerName", 50, model.CustomerName)
													  .AddNVarchar("customerAddress", 50, model.CustomerAddress)
													  .AddNVarchar("customerPhone", 50, model.CustomerPhone)
													  .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private ProductDTO ToProductDTO(DataRow row)
		{
			return new ProductDTO
			{
				ProductId = row.Field<int>("ProductId"),
				ProductName = row.Field<string>("ProductName"),
				CustomerName = row.Field<string>("CustomerName"),
				CustomerAddress = row.Field<string>("CustomerAddress"),
				CustomerPhone = row.Field<string>("CustomerPhone"),
				DeliveryName = row.Field<string>("DeliveryName"),
				DeliveryPhone = row.Field<string>("DeliveryPhone"),
				ArriveDate = row.Field<DateTime>("ArriveDate"),
			};
		}

		private ProductDTO ToCustomerDTO(DataRow row)
		{
			return new ProductDTO
			{
				CustomerId = row.Field<int>("CustomerId"),
				CustomerName = row.Field<string>("CustomerName"),
				CustomerAddress = row.Field<string>("CustomerAddress"),
				CustomerPhone = row.Field<string>("CustomerPhone"),
			};
		}

		public void CreatePorduct(CreateVM model)
		{
			string sql = @"INSERT INTO products
							(deliveryId, productName, customerId, arriveDate)
							VALUES
							(@deliveryId, @productName, @customerId, @arriveDate)";

			var parameters = new SqlParameterBuilder()
				.AddInt("deliveryId", model.DeliveryId)
				.AddInt("customerId", model.CustomerId)
				.AddNVarchar("productName", 50, model.ProductName)
				.AddDateTime("arriveDate", model.ArriveDate)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		internal IEnumerable<ProductDTO> GetCustomerAll()
		{
			string sql = @"SELECT * FROM customers";
			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCustomerDTO(row));
		}

		public ProductDTO GetCustomer(int customerId)
		{
			string sql = "SELECt * FROM Customers WHERE customerId=@customerId";
			var parameters = new SqlParameterBuilder().AddInt("customerId", customerId).Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			if (data.Rows.Count == 0)
			{

				// this.Close();
				throw new Exception("抱歉, 找不到要編輯的資料");
			}
			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ProductDTO(data.Rows[0]);
		}
		public ProductDTO ProductDTO(DataRow row)
		{
			return new ProductDTO
			{
				CustomerId = row.Field<int>("CustomerId"),
				CustomerName = row.Field<string>("CustomerName"),
				CustomerAddress = row.Field<string>("CustomerAddress"),
				CustomerPhone = row.Field<string>("CustomerPhone"),
			};
		}

		public void Delete(CustomersVM model)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo,
														   MessageBoxIcon.Question)
														  != DialogResult.Yes)
			{
				return;
			}
			string sql = @"DELETE FROM Customers WHERE customerId=@customerId";
			var parameters = new SqlParameterBuilder().AddInt("customerId", model.CustomerId)
													  .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void EditCustomer(CustomersVM model)
		{
			string sql = @"UPDATE customers SET customerName=@customerName,
							customerAddress=@customerAddress, customerPhone=@customerPhone
							WHERE customerId=@customerId";

			var parameters = new SqlParameterBuilder().AddNVarchar("customerName", 50, model.CustomerName)
														.AddNVarchar("customerAddress", 50, model.CustomerAddress)
														.AddNVarchar("customerPhone", 50, model.CustomerPhone)
														.AddInt("customerId", model.CustomerId)
														.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public UserDTO Get(string account)
		{
			string sql = "SELECT * FROM users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserDTO(data.Rows[0]);
		}
		public bool Authenticate(LoginVM model)
		{
			var user = Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}
		private UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
			};
		}
	}
}
