using ISpan.inventory.Infra.DAOs;
using ISpan.inventory.Models.DTOs;
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
	public partial class CreateForm : Form
	{
		public CreateForm()
		{
			InitializeComponent();
			initForm();
		}
		private void initForm()
		{
			// 設定 categoryIdComboBox property
			deliveryCombox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM deliveries";
			var dbHelper = new SqlDbHelper("default");

			List<DeliveryVM> delivery = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToDeliveryVM(row))
				.Prepend(new DeliveryVM { DeliveryId = 0, DeliveryName = String.Empty })
				.ToList();

			this.deliveryCombox.DataSource = delivery;

			customercomBox.DropDownStyle = ComboBoxStyle.DropDownList;

			sql = "SELECT * FROM customers";
			dbHelper = new SqlDbHelper("default");

			List<CustomerVM> customer = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToCustomerVM(row))
				.Prepend(new CustomerVM { CustomerId = 0, CustomerName = String.Empty })
				.ToList();

			this.customercomBox.DataSource = customer;
		}
		private DeliveryVM ToDeliveryVM(DataRow row)
		{
			return new DeliveryVM
			{
				DeliveryId = row.Field<int>("DeliveryId"),
				DeliveryName = row.Field<string>("DeliveryName"),
				DeliveryPhone = row.Field<string>("DeliveryPhone"),
			};
		}
		private CustomerVM ToCustomerVM(DataRow row)
		{
			return new CustomerVM
			{
				CustomerId = row.Field<int>("CustomerId"),
				CustomerName = row.Field<string>("CustomerName"),
			};
		}
		private void saveBtn_Click(object sender, EventArgs e)
		{
			int deliveryId = ((DeliveryVM)this.deliveryCombox.SelectedItem).DeliveryId;
			int customerId = ((CustomerVM)this.customercomBox.SelectedItem).CustomerId;
			string productName = productTxtBox.Text;
			DateTime arriveDate = DateTime.Parse(arriveTxtBox.Text);

			CreateVM model = new CreateVM
			{
				CustomerId = customerId,
				DeliveryId = deliveryId,
				ProductName = productName,
				ArriveDate = arriveDate,
			};
			
			try
			{
				new ProductDAO().CreatePorduct(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因: {ex.Message}");
			}
			this.DialogResult = DialogResult.OK;
		}
	}
}
