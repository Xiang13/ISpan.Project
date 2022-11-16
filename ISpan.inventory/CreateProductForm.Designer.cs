namespace ISpan.inventory
{
	partial class CreateProductForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.supplierComBox = new System.Windows.Forms.ComboBox();
			this.supplierVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productNameTxtBox = new System.Windows.Forms.TextBox();
			this.unitPriceTxtBox = new System.Windows.Forms.TextBox();
			this.quentityTxtBox = new System.Windows.Forms.TextBox();
			this.totalPriceTxtBox = new System.Windows.Forms.TextBox();
			this.createBtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.orderDtPicker = new System.Windows.Forms.DateTimePicker();
			this.arriveDtPicker = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.supplierVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "廠商名稱:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "產品名稱:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "單價:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "數量:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "總計:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "訂單日期:";
			// 
			// supplierComBox
			// 
			this.supplierComBox.DataSource = this.supplierVMBindingSource;
			this.supplierComBox.DisplayMember = "Supplier_Name";
			this.supplierComBox.FormattingEnabled = true;
			this.supplierComBox.Location = new System.Drawing.Point(107, 44);
			this.supplierComBox.Name = "supplierComBox";
			this.supplierComBox.Size = new System.Drawing.Size(200, 20);
			this.supplierComBox.TabIndex = 1;
			this.supplierComBox.ValueMember = "Supplier_Id";
			// 
			// supplierVMBindingSource
			// 
			this.supplierVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.SupplierVM);
			// 
			// productNameTxtBox
			// 
			this.productNameTxtBox.Location = new System.Drawing.Point(107, 94);
			this.productNameTxtBox.Name = "productNameTxtBox";
			this.productNameTxtBox.Size = new System.Drawing.Size(200, 22);
			this.productNameTxtBox.TabIndex = 2;
			// 
			// unitPriceTxtBox
			// 
			this.unitPriceTxtBox.Location = new System.Drawing.Point(107, 149);
			this.unitPriceTxtBox.Name = "unitPriceTxtBox";
			this.unitPriceTxtBox.Size = new System.Drawing.Size(200, 22);
			this.unitPriceTxtBox.TabIndex = 2;
			// 
			// quentityTxtBox
			// 
			this.quentityTxtBox.Location = new System.Drawing.Point(107, 208);
			this.quentityTxtBox.Name = "quentityTxtBox";
			this.quentityTxtBox.Size = new System.Drawing.Size(200, 22);
			this.quentityTxtBox.TabIndex = 2;
			// 
			// totalPriceTxtBox
			// 
			this.totalPriceTxtBox.Location = new System.Drawing.Point(107, 264);
			this.totalPriceTxtBox.Name = "totalPriceTxtBox";
			this.totalPriceTxtBox.Size = new System.Drawing.Size(200, 22);
			this.totalPriceTxtBox.TabIndex = 2;
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(424, 44);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(73, 30);
			this.createBtn.TabIndex = 3;
			this.createBtn.Text = "新增";
			this.createBtn.UseVisualStyleBackColor = true;
			this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(36, 384);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 12);
			this.label7.TabIndex = 0;
			this.label7.Text = "交貨日期:";
			// 
			// orderDtPicker
			// 
			this.orderDtPicker.Location = new System.Drawing.Point(107, 319);
			this.orderDtPicker.Name = "orderDtPicker";
			this.orderDtPicker.Size = new System.Drawing.Size(200, 22);
			this.orderDtPicker.TabIndex = 6;
			// 
			// arriveDtPicker
			// 
			this.arriveDtPicker.Location = new System.Drawing.Point(107, 377);
			this.arriveDtPicker.Name = "arriveDtPicker";
			this.arriveDtPicker.Size = new System.Drawing.Size(200, 22);
			this.arriveDtPicker.TabIndex = 6;
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1287, 450);
			this.Controls.Add(this.arriveDtPicker);
			this.Controls.Add(this.orderDtPicker);
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.totalPriceTxtBox);
			this.Controls.Add(this.quentityTxtBox);
			this.Controls.Add(this.unitPriceTxtBox);
			this.Controls.Add(this.productNameTxtBox);
			this.Controls.Add(this.supplierComBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CreateProductForm";
			this.Text = "CreateProductForm";
			((System.ComponentModel.ISupportInitialize)(this.supplierVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox supplierComBox;
		private System.Windows.Forms.TextBox productNameTxtBox;
		private System.Windows.Forms.TextBox unitPriceTxtBox;
		private System.Windows.Forms.TextBox quentityTxtBox;
		private System.Windows.Forms.TextBox totalPriceTxtBox;
		private System.Windows.Forms.BindingSource supplierVMBindingSource;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker orderDtPicker;
		private System.Windows.Forms.DateTimePicker arriveDtPicker;
	}
}