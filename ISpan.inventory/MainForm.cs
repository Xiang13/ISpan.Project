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
	public partial class MainForm : Form
	{
		bool isFind = false;
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void 查詢ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//foreach (Form form in this.MdiChildren)
			//{
			//	if (form.Name == "ProductForm")
			//	{
			//		isFind = true;
			//		form.MdiParent = this;
			//		form.Focus();
			//		return;
			//	}
			//}
			//if (isFind == false)
			//{
			//	ProductForm childForm = new ProductForm();
			//	childForm.MdiParent = this;
			//	childForm.Show();
			//}
			var frm = new ProductForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//foreach (Form form in this.MdiChildren)
			//{
			//	if (form.Name == "EditForm")
			//	{
			//		isFind = true;
			//		form.MdiParent = this;
			//		form.Focus();
			//	}
			//}
			//if (isFind == false)
			//{
			//	EditForm childForm = new EditForm();
			//	childForm.MdiParent = this;
			//	childForm.Show();
			//}
			var frm = new EditForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
