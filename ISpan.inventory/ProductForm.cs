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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory
{
	public partial class ProductForm : Form
	{
		private ProductIndexVM[] products = null;
		public ProductForm()
		{
			InitializeComponent();
			initForm();
			// 顯示記錄
			DisplayProducts();
		}

		private void initForm()
		{
			// 設定 categoryIdComboBox property
			deliverycomBox.DropDownStyle = ComboBoxStyle.DropDownList;

			var sql = "SELECT * FROM deliveries";
			var dbHelper = new SqlDbHelper("default");

			List<DeliveryVM> delivery = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToDeliveryVM(row))
				.Prepend(new DeliveryVM { DeliveryId = 0, DeliveryName = String.Empty })
				.ToList();



			this.deliverycomBox.DataSource = delivery;
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

		private void DisplayProducts()
		{
			// 取得篩選值
			int deliveryId = ((DeliveryVM)deliverycomBox.SelectedItem).DeliveryId;
			int customerId = ((CustomerVM)customercomBox.SelectedItem).CustomerId;

			products = new ProductDAO().GetAll(deliveryId, customerId)
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			
			BindData(products);
		}

		private void BindData(ProductIndexVM[] products)
		{
			dataGridView1.DataSource = products;
		}

		private CustomerVM ToCustomerVM(DataRow row)
		{
			return new CustomerVM
			{
				CustomerId = row.Field<int>("CustomerId"),
				CustomerName = row.Field<string>("CustomerName"),
			};
		}

		public static DeliveryVM ToDeliveryVM(DataRow row)
		{
			return new DeliveryVM
			{
				DeliveryId = row.Field<int>("DeliveryId"),
				DeliveryName = row.Field<string>("DeliveryName"),
				DeliveryPhone = row.Field<string>("DeliveryPhone"),
			};
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}

		private void editCustomerBtn_Click(object sender, EventArgs e)
		{
			var frm = new EditForm();
			DialogResult result = frm.ShowDialog();
		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			BindData(products);
			DisplayProducts();
			initForm();
		}
	}
}
