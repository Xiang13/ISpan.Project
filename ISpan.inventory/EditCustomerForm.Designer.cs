namespace ISpan.inventory
{
	partial class EditCustomerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.customerNameTxtBox = new System.Windows.Forms.TextBox();
			this.customerAddressTxtBox = new System.Windows.Forms.TextBox();
			this.customerPhoneTxtBox = new System.Windows.Forms.TextBox();
			this.saveCustomBtn = new System.Windows.Forms.Button();
			this.deleteCustomBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// customerNameTxtBox
			// 
			this.customerNameTxtBox.Location = new System.Drawing.Point(72, 48);
			this.customerNameTxtBox.Name = "customerNameTxtBox";
			this.customerNameTxtBox.Size = new System.Drawing.Size(153, 22);
			this.customerNameTxtBox.TabIndex = 0;
			// 
			// customerAddressTxtBox
			// 
			this.customerAddressTxtBox.Location = new System.Drawing.Point(72, 101);
			this.customerAddressTxtBox.Name = "customerAddressTxtBox";
			this.customerAddressTxtBox.Size = new System.Drawing.Size(153, 22);
			this.customerAddressTxtBox.TabIndex = 1;
			// 
			// customerPhoneTxtBox
			// 
			this.customerPhoneTxtBox.Location = new System.Drawing.Point(72, 156);
			this.customerPhoneTxtBox.Name = "customerPhoneTxtBox";
			this.customerPhoneTxtBox.Size = new System.Drawing.Size(153, 22);
			this.customerPhoneTxtBox.TabIndex = 2;
			// 
			// saveCustomBtn
			// 
			this.saveCustomBtn.Location = new System.Drawing.Point(39, 236);
			this.saveCustomBtn.Name = "saveCustomBtn";
			this.saveCustomBtn.Size = new System.Drawing.Size(75, 23);
			this.saveCustomBtn.TabIndex = 3;
			this.saveCustomBtn.Text = "保存";
			this.saveCustomBtn.UseVisualStyleBackColor = true;
			this.saveCustomBtn.Click += new System.EventHandler(this.saveCustomBtn_Click);
			// 
			// deleteCustomBtn
			// 
			this.deleteCustomBtn.Location = new System.Drawing.Point(184, 236);
			this.deleteCustomBtn.Name = "deleteCustomBtn";
			this.deleteCustomBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteCustomBtn.TabIndex = 4;
			this.deleteCustomBtn.Text = "刪除";
			this.deleteCustomBtn.UseVisualStyleBackColor = true;
			this.deleteCustomBtn.Click += new System.EventHandler(this.deleteCustomBtn_Click);
			// 
			// EditCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 306);
			this.Controls.Add(this.deleteCustomBtn);
			this.Controls.Add(this.saveCustomBtn);
			this.Controls.Add(this.customerPhoneTxtBox);
			this.Controls.Add(this.customerAddressTxtBox);
			this.Controls.Add(this.customerNameTxtBox);
			this.MaximizeBox = false;
			this.Name = "EditCustomerForm";
			this.Text = "編輯客戶資訊";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox customerNameTxtBox;
		private System.Windows.Forms.TextBox customerAddressTxtBox;
		private System.Windows.Forms.TextBox customerPhoneTxtBox;
		private System.Windows.Forms.Button saveCustomBtn;
		private System.Windows.Forms.Button deleteCustomBtn;
	}
}