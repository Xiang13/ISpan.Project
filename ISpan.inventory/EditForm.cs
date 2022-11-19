using ISpan.inventory.Infra.DAOs;
using ISpan.inventory.Models.DTOs;
using ISpan.inventory.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory
{
	public partial class EditForm : Form
	{
		private CustomersVM[] customers = null;
		public EditForm()
		{
			InitializeComponent();
			// 顯示記錄
			DisplayCustomers();

		}

		private void DisplayCustomers()
		{
			customers = new ProductDAO().GetCustomerAll()
						.Select(dto => dto.ToCustomerVM())
						.ToArray();

			BindData(customers);
		}

		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(customers);
		}
		private void BindData(CustomersVM[] customers)
		{
			dataGridView1.DataSource = customers;
		}

		private void createCustomBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateCustomerForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayCustomers();
			}
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;  // 使用者點到的索引值

			if (rowIndx < 0) return;

			CustomersVM row = this.customers[rowIndx];  // 使用者點到的那一筆紀錄
			int customerId = row.CustomerId;            // 使用者點到的那一筆紀錄的 id 值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditCustomerForm(customerId);
			// frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayCustomers();
			}
		}
	}
}
