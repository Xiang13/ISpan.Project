namespace ISpan.inventory
{
	partial class CreateCustomerForm
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.customerAddressTxtBox = new System.Windows.Forms.TextBox();
			this.customerTxtBox = new System.Windows.Forms.TextBox();
			this.customerPhoneTxtBox = new System.Windows.Forms.TextBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "客戶";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "客戶地址";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "客戶連絡方式";
			// 
			// customerAddressTxtBox
			// 
			this.customerAddressTxtBox.Location = new System.Drawing.Point(125, 84);
			this.customerAddressTxtBox.Name = "customerAddressTxtBox";
			this.customerAddressTxtBox.Size = new System.Drawing.Size(121, 22);
			this.customerAddressTxtBox.TabIndex = 4;
			// 
			// customerTxtBox
			// 
			this.customerTxtBox.Location = new System.Drawing.Point(125, 38);
			this.customerTxtBox.Name = "customerTxtBox";
			this.customerTxtBox.Size = new System.Drawing.Size(121, 22);
			this.customerTxtBox.TabIndex = 5;
			// 
			// customerPhoneTxtBox
			// 
			this.customerPhoneTxtBox.Location = new System.Drawing.Point(125, 136);
			this.customerPhoneTxtBox.Name = "customerPhoneTxtBox";
			this.customerPhoneTxtBox.Size = new System.Drawing.Size(121, 22);
			this.customerPhoneTxtBox.TabIndex = 6;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(171, 195);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 10;
			this.saveBtn.Text = "儲存";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// CreateCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 252);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.customerAddressTxtBox);
			this.Controls.Add(this.customerTxtBox);
			this.Controls.Add(this.customerPhoneTxtBox);
			this.Name = "CreateCustomerForm";
			this.Text = "CreateCustomerForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox customerAddressTxtBox;
		private System.Windows.Forms.TextBox customerTxtBox;
		private System.Windows.Forms.TextBox customerPhoneTxtBox;
		private System.Windows.Forms.Button saveBtn;
	}
}