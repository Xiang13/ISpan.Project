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
	public partial class CreateProductForm : Form
	{
		private SupplierVM[] supplier = null;
		public CreateProductForm()
		{
			InitializeComponent();
			InitForm();
		}

		private void InitForm()
		{
			supplier = new InventoryService().GetSupplier().ToArray();
			this.supplierComBox.DataSource = supplier;
		}

		private void createBtn_Click(object sender, EventArgs e)
		{
			// 取得表單各欄位的值
			string supplier = supplierComBox.SelectedIndex.ToString();
			string productName = productNameTxtBox.Text;
			int unitPrice = Convert.ToInt32(unitPriceTxtBox);
			int quentity = Convert.ToInt32(quentityTxtBox);
			int totalPrice = Convert.ToInt32(totalPriceTxtBox);
			DateTime orderDate = orderDtPicker.Value.Date;
			DateTime arriveDate = arriveDtPicker.Value.Date;

			// 將它們繫結到 ViewModel
			CreateProductVM model = new CreateProductVM()
			{
				Supplier_Name = supplier,
				Product_Name = productName,
				Unit_Price = unitPrice,
				Quentity = quentity,
				TotalPrice = totalPrice,
				OrderDate = orderDate, 
				ArriveDate = arriveDate,

			};
			//new InventoryService().Create(model);
			this.DialogResult = DialogResult.OK;

		}
	}
}
