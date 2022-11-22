namespace ISpan.inventory
{
	partial class ProductForm
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
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deliveryPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.deliverycomBox = new System.Windows.Forms.ComboBox();
			this.deliveryVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.deliveryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchBtn = new System.Windows.Forms.Button();
			this.createBtn = new System.Windows.Forms.Button();
			this.customercomBox = new System.Windows.Forms.ComboBox();
			this.customerVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerVMBindingSource)).BeginInit();
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
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.deliveryNameDataGridViewTextBoxColumn,
            this.deliveryPhoneDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productIndexVMBindingSource3;
			this.dataGridView1.Location = new System.Drawing.Point(12, 142);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(924, 272);
			this.dataGridView1.TabIndex = 4;
			// 
			// productIdDataGridViewTextBoxColumn
			// 
			this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
			this.productIdDataGridViewTextBoxColumn.HeaderText = "產品編號";
			this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
			this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "產品名稱";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "客戶名稱";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerAddressDataGridViewTextBoxColumn
			// 
			this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
			this.customerAddressDataGridViewTextBoxColumn.HeaderText = "客戶地址";
			this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
			this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerPhoneDataGridViewTextBoxColumn
			// 
			this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
			this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "客戶聯絡方式";
			this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
			this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.customerPhoneDataGridViewTextBoxColumn.Width = 110;
			// 
			// deliveryNameDataGridViewTextBoxColumn
			// 
			this.deliveryNameDataGridViewTextBoxColumn.DataPropertyName = "DeliveryName";
			this.deliveryNameDataGridViewTextBoxColumn.HeaderText = "貨運公司";
			this.deliveryNameDataGridViewTextBoxColumn.Name = "deliveryNameDataGridViewTextBoxColumn";
			this.deliveryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// deliveryPhoneDataGridViewTextBoxColumn
			// 
			this.deliveryPhoneDataGridViewTextBoxColumn.DataPropertyName = "DeliveryPhone";
			this.deliveryPhoneDataGridViewTextBoxColumn.HeaderText = "貨運公司聯絡方式";
			this.deliveryPhoneDataGridViewTextBoxColumn.Name = "deliveryPhoneDataGridViewTextBoxColumn";
			this.deliveryPhoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.deliveryPhoneDataGridViewTextBoxColumn.Width = 130;
			// 
			// arriveDateDataGridViewTextBoxColumn
			// 
			this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "ArriveDate";
			this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到達日期";
			this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
			this.arriveDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productIndexVMBindingSource3
			// 
			this.productIndexVMBindingSource3.DataSource = typeof(ISpan.inventory.Models.ViewModels.ProductIndexVM);
			// 
			// productIndexVMBindingSource2
			// 
			this.productIndexVMBindingSource2.DataSource = typeof(ISpan.inventory.Models.ViewModels.ProductIndexVM);
			// 
			// productIndexVMBindingSource1
			// 
			this.productIndexVMBindingSource1.DataSource = typeof(ISpan.inventory.Models.ViewModels.ProductIndexVM);
			// 
			// productIndexVMBindingSource
			// 
			this.productIndexVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.ProductIndexVM);
			// 
			// deliverycomBox
			// 
			this.deliverycomBox.DataSource = this.deliveryVMBindingSource1;
			this.deliverycomBox.DisplayMember = "DeliveryName";
			this.deliverycomBox.FormattingEnabled = true;
			this.deliverycomBox.Location = new System.Drawing.Point(36, 53);
			this.deliverycomBox.Name = "deliverycomBox";
			this.deliverycomBox.Size = new System.Drawing.Size(121, 20);
			this.deliverycomBox.TabIndex = 0;
			this.deliverycomBox.ValueMember = "DeliveryId";
			// 
			// deliveryVMBindingSource1
			// 
			this.deliveryVMBindingSource1.DataSource = typeof(ISpan.inventory.Models.ViewModels.DeliveryVM);
			// 
			// deliveryVMBindingSource
			// 
			this.deliveryVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.DeliveryVM);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(364, 50);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 2;
			this.searchBtn.Text = "搜尋";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// createBtn
			// 
			this.createBtn.Location = new System.Drawing.Point(476, 50);
			this.createBtn.Name = "createBtn";
			this.createBtn.Size = new System.Drawing.Size(75, 23);
			this.createBtn.TabIndex = 3;
			this.createBtn.Text = "新增商品";
			this.createBtn.UseVisualStyleBackColor = true;
			this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
			// 
			// customercomBox
			// 
			this.customercomBox.DataSource = this.customerVMBindingSource;
			this.customercomBox.DisplayMember = "CustomerName";
			this.customercomBox.FormattingEnabled = true;
			this.customercomBox.Location = new System.Drawing.Point(186, 53);
			this.customercomBox.Name = "customercomBox";
			this.customercomBox.Size = new System.Drawing.Size(121, 20);
			this.customercomBox.TabIndex = 1;
			this.customercomBox.ValueMember = "CustomerId";
			// 
			// customerVMBindingSource
			// 
			this.customerVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomerVM);
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 426);
			this.Controls.Add(this.createBtn);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.customercomBox);
			this.Controls.Add(this.deliverycomBox);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ProductForm";
			this.Text = "訂單資訊";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource;
		private System.Windows.Forms.ComboBox deliverycomBox;
		private System.Windows.Forms.BindingSource deliveryVMBindingSource;
		private System.Windows.Forms.BindingSource deliveryVMBindingSource1;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.ComboBox customercomBox;
		private System.Windows.Forms.BindingSource customerVMBindingSource;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource productIndexVMBindingSource3;
	}
}