namespace ISpan.inventory
{
	partial class inventoryForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arriverDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddProductBtn = new System.Windows.Forms.Button();
			this.supplierComBox1 = new System.Windows.Forms.ComboBox();
			this.inventoryIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.inventoryIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.inventoryIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.supplierVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.inventoryDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn,
            this.supplierPhoneDataGridViewTextBoxColumn,
            this.orderQuantityDataGridViewTextBoxColumn,
            this.arriverDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.inventoryIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 185);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1304, 253);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// productIdDataGridViewTextBoxColumn
			// 
			this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
			this.productIdDataGridViewTextBoxColumn.HeaderText = "產品編號";
			this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
			this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "產品名稱";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "單價";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// inventoryDataGridViewTextBoxColumn
			// 
			this.inventoryDataGridViewTextBoxColumn.DataPropertyName = "inventory";
			this.inventoryDataGridViewTextBoxColumn.HeaderText = "庫存量";
			this.inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
			this.inventoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// supplierNameDataGridViewTextBoxColumn
			// 
			this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name";
			this.supplierNameDataGridViewTextBoxColumn.HeaderText = "供應商";
			this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
			this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// supplierAddressDataGridViewTextBoxColumn
			// 
			this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Address";
			this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "供應商地址";
			this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
			this.supplierAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// supplierPhoneDataGridViewTextBoxColumn
			// 
			this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Phone";
			this.supplierPhoneDataGridViewTextBoxColumn.HeaderText = "供應商聯絡方式";
			this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
			this.supplierPhoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.supplierPhoneDataGridViewTextBoxColumn.Width = 150;
			// 
			// orderQuantityDataGridViewTextBoxColumn
			// 
			this.orderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Order_Quantity";
			this.orderQuantityDataGridViewTextBoxColumn.HeaderText = "訂單數量";
			this.orderQuantityDataGridViewTextBoxColumn.Name = "orderQuantityDataGridViewTextBoxColumn";
			this.orderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// arriverDateDataGridViewTextBoxColumn
			// 
			this.arriverDateDataGridViewTextBoxColumn.DataPropertyName = "ArriverDate";
			this.arriverDateDataGridViewTextBoxColumn.HeaderText = "交貨日期";
			this.arriverDateDataGridViewTextBoxColumn.Name = "arriverDateDataGridViewTextBoxColumn";
			this.arriverDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// inventoryIndexVMBindingSource
			// 
			this.inventoryIndexVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.InventoryIndexVM);
			// 
			// AddProductBtn
			// 
			this.AddProductBtn.Location = new System.Drawing.Point(1207, 66);
			this.AddProductBtn.Name = "AddProductBtn";
			this.AddProductBtn.Size = new System.Drawing.Size(68, 37);
			this.AddProductBtn.TabIndex = 1;
			this.AddProductBtn.Text = "新增";
			this.AddProductBtn.UseVisualStyleBackColor = true;
			this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
			// 
			// supplierComBox1
			// 
			this.supplierComBox1.DataSource = this.inventoryIndexVMBindingSource3;
			this.supplierComBox1.DisplayMember = "Supplier_Name";
			this.supplierComBox1.FormattingEnabled = true;
			this.supplierComBox1.Location = new System.Drawing.Point(12, 42);
			this.supplierComBox1.Name = "supplierComBox1";
			this.supplierComBox1.Size = new System.Drawing.Size(121, 20);
			this.supplierComBox1.TabIndex = 2;
			this.supplierComBox1.ValueMember = "Supplier_Id";
			// 
			// inventoryIndexVMBindingSource3
			// 
			this.inventoryIndexVMBindingSource3.DataSource = typeof(ISpan.inventory.Models.ViewModels.InventoryIndexVM);
			// 
			// inventoryIndexVMBindingSource2
			// 
			this.inventoryIndexVMBindingSource2.DataSource = typeof(ISpan.inventory.Models.ViewModels.InventoryIndexVM);
			// 
			// inventoryIndexVMBindingSource1
			// 
			this.inventoryIndexVMBindingSource1.DataSource = typeof(ISpan.inventory.Models.ViewModels.InventoryIndexVM);
			// 
			// supplierVMBindingSource
			// 
			this.supplierVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.SupplierVM);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(58, 135);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 3;
			this.searchBtn.Text = "搜尋";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// inventoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1328, 450);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.supplierComBox1);
			this.Controls.Add(this.AddProductBtn);
			this.Controls.Add(this.dataGridView1);
			this.Name = "inventoryForm";
			this.Text = "inventoryForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource inventoryIndexVMBindingSource;
		private System.Windows.Forms.Button AddProductBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arriverDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox supplierComBox1;
		private System.Windows.Forms.BindingSource supplierVMBindingSource;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.BindingSource inventoryIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource inventoryIndexVMBindingSource2;
		private System.Windows.Forms.BindingSource inventoryIndexVMBindingSource3;
	}
}