namespace ISpan.inventory
{
	partial class CreateForm
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
			this.components = new System.ComponentModel.Container();
			this.saveBtn = new System.Windows.Forms.Button();
			this.productTxtBox = new System.Windows.Forms.TextBox();
			this.arriveTxtBox = new System.Windows.Forms.TextBox();
			this.deliveryCombox = new System.Windows.Forms.ComboBox();
			this.deliveryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.customercomBox = new System.Windows.Forms.ComboBox();
			this.customerVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(572, 144);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 0;
			this.saveBtn.Text = "儲存";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// productTxtBox
			// 
			this.productTxtBox.Location = new System.Drawing.Point(121, 145);
			this.productTxtBox.Name = "productTxtBox";
			this.productTxtBox.Size = new System.Drawing.Size(121, 22);
			this.productTxtBox.TabIndex = 1;
			// 
			// arriveTxtBox
			// 
			this.arriveTxtBox.Location = new System.Drawing.Point(400, 145);
			this.arriveTxtBox.Name = "arriveTxtBox";
			this.arriveTxtBox.Size = new System.Drawing.Size(121, 22);
			this.arriveTxtBox.TabIndex = 1;
			// 
			// deliveryCombox
			// 
			this.deliveryCombox.DataSource = this.deliveryVMBindingSource;
			this.deliveryCombox.DisplayMember = "DeliveryName";
			this.deliveryCombox.FormattingEnabled = true;
			this.deliveryCombox.Location = new System.Drawing.Point(121, 34);
			this.deliveryCombox.Name = "deliveryCombox";
			this.deliveryCombox.Size = new System.Drawing.Size(121, 20);
			this.deliveryCombox.TabIndex = 2;
			this.deliveryCombox.ValueMember = "DeliveryId";
			// 
			// deliveryVMBindingSource
			// 
			this.deliveryVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.DeliveryVM);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(309, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "到貨日期";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "商品";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 3;
			this.label6.Text = "貨運公司";
			// 
			// customercomBox
			// 
			this.customercomBox.DataSource = this.customerVMBindingSource;
			this.customercomBox.DisplayMember = "CustomerName";
			this.customercomBox.FormattingEnabled = true;
			this.customercomBox.Location = new System.Drawing.Point(400, 34);
			this.customercomBox.Name = "customercomBox";
			this.customercomBox.Size = new System.Drawing.Size(121, 20);
			this.customercomBox.TabIndex = 2;
			this.customercomBox.ValueMember = "CustomerId";
			// 
			// customerVMBindingSource
			// 
			this.customerVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomerVM);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(309, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "客戶";
			// 
			// CreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 205);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.customercomBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.deliveryCombox);
			this.Controls.Add(this.arriveTxtBox);
			this.Controls.Add(this.productTxtBox);
			this.Controls.Add(this.saveBtn);
			this.Name = "CreateForm";
			this.Text = "CreateForm";
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.TextBox productTxtBox;
		private System.Windows.Forms.TextBox arriveTxtBox;
		private System.Windows.Forms.ComboBox deliveryCombox;
		private System.Windows.Forms.BindingSource deliveryVMBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox customercomBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource customerVMBindingSource;
	}
}