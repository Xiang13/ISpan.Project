using ISpan.inventory.Models.Services;
using ISpan.inventory.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.inventory
{
	public partial class inventoryForm : Form
	{
		private SupplierVM[] supplier = null;
		private InventoryIndexVM[] inventory = null;
		public inventoryForm()
		{
			InitializeComponent();
			DisplayInventories();
			InitForm();
		}

		private void InitForm()
		{
			supplier = new InventoryService().GetSupplier().ToArray();
			this.supplierComBox1.DataSource = supplier;
		}
		private void DisplayInventories()
		{
			inventory = new InventoryService().GetAll().ToArray();
			BinData(inventory);
		}
		private void BinData(InventoryIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private void AddProductBtn_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayInventories();
			}
		}
		private void searchBtn_Click(object sender, EventArgs e)
		{
			DisplayInventory();
		}
		private void DisplayInventory()
		{
			// 取得篩選值
			int supplierId = ((SupplierVM)supplierComBox1.SelectedItem).Supplier_Id;

			inventory = new InventoryService().GetInitSupplier(supplierId).ToArray();
			BinData(inventory);
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;  // 使用者點到的索引值
			if (rowIndx < 0) return;
			InventoryIndexVM row = this.inventory[rowIndx];  // 使用者點到的那一筆紀錄
			int id = row.Product_Id;            // 使用者點到的那一筆紀錄的 id 值

			var frm = new EditProductForm(id);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayInventory();
			}
		}
	}
}
