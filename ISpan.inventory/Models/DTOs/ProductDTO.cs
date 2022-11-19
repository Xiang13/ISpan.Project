using ISpan.inventory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.inventory.Models.DTOs
{
	public class ProductDTO
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }
		public string CustomerPhone { get; set; }
		public int DeliveryId { get; set; }
		public string DeliveryName { get; set; }
		public string DeliveryPhone { get; set; }
		public DateTime ArriveDate { get; set; }
	}
	public class UserDTO
	{
		public int Id { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }
	}
	public static class ProductDTOExts
	{
		public static ProductIndexVM ToIndexVM(this ProductDTO dto)
		{
			return new ProductIndexVM
			{
				ProductId = dto.ProductId,
				ProductName = dto.ProductName,
				CustomerName = dto.CustomerName,
				CustomerAddress = dto.CustomerAddress,
				CustomerPhone = dto.CustomerPhone,
				DeliveryName = dto.DeliveryName,
				DeliveryPhone = dto.DeliveryPhone,
				ArriveDate = dto.ArriveDate,
			};
		}
		public static CustomersIndexVM ToCustomerIndexVM(this ProductDTO dto)
		{
			return new CustomersIndexVM
			{
				CustomerName = dto.CustomerName,
				CustomerAddress = dto.CustomerAddress,
				CustomerPhone = dto.CustomerPhone,
			};
		}
		public static CustomersVM ToCustomerVM(this ProductDTO dto)
		{
			return new CustomersVM
			{
				CustomerId = dto.CustomerId,
				CustomerName = dto.CustomerName,
				CustomerAddress = dto.CustomerAddress,
				CustomerPhone = dto.CustomerPhone,
			};
		}
		public static ProductIndexVM ToProductVM(this DataRow row)
		{
			return new ProductIndexVM
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
		public static DeliveryVM ToVM(this DataRow row)
		{
			return new DeliveryVM
			{
				DeliveryId = row.Field<int>("DeliveryId"),
				DeliveryName = row.Field<string>("DeliveryName"),
				DeliveryPhone = row.Field<string>("DeliveryPhone"),
			};
		}
	}
	
}

