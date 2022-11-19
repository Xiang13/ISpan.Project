using ISpan.inventory.Infra.DAOs;
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
	public partial class CreateCustomerForm : Form
	{
		public CreateCustomerForm()
		{
			InitializeComponent();

		}

		private void saveBtn_Click(object sender, EventArgs e)
		{

			string customerName = customerTxtBox.Text;
			string customerAddress = customerAddressTxtBox.Text;
			string customerPhone = customerPhoneTxtBox.Text;

			CreateCustomerVM model = new CreateCustomerVM
			{
				CustomerName = customerName,
				CustomerAddress = customerAddress,
				CustomerPhone = customerPhone
			};
			try
			{
				new ProductDAO().CreateCustomer(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"新增失敗, 原因: {ex.Message}");
			}
		}
	}
}
