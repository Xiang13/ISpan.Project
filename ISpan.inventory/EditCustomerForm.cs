using ISpan.inventory.Infra.DAOs;
using ISpan.inventory.Models.DTOs;
using ISpan.inventory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISpan.inventory
{
	public partial class EditCustomerForm : Form
	{
		private int customerId;
		public EditCustomerForm(int customerId)
		{
			InitializeComponent();
			this.customerId = customerId;
			BindData(customerId);
		}

		private void BindData(int customerId)
		{
			ProductDTO dto = new ProductDAO().GetCustomer(customerId);

			CustomersVM model = dto.ToCustomerVM();
			customerNameTxtBox.Text = model.CustomerName;
			customerAddressTxtBox.Text = model.CustomerAddress;
			customerPhoneTxtBox.Text = model.CustomerPhone;
		}

		private void deleteCustomBtn_Click(object sender, EventArgs e)
		{
			CustomersVM model = new CustomersVM
			{
				CustomerId = this.customerId,
			};
			new ProductDAO().Delete(model);
			this.DialogResult = DialogResult.OK;
		}

		private void saveCustomBtn_Click(object sender, EventArgs e)
		{
			// 取得表單各欄位的值
			string customerName = customerNameTxtBox.Text;
			string customerAddress = customerAddressTxtBox.Text;
			string customerPhone = customerPhoneTxtBox.Text;
			CustomersVM model = new CustomersVM
			{
				CustomerId = this.customerId,
				CustomerName = customerName,
				CustomerAddress = customerAddress,
				CustomerPhone = customerPhone
			};

			try
			{
				new ProductDAO().EditCustomer(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因: {ex.Message}");
			}
		}
	}
}
