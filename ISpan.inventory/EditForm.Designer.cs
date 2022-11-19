namespace ISpan.inventory
{
	partial class EditForm
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
			this.createCustomBtn = new System.Windows.Forms.Button();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customersIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.customersVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.deliveryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.customersIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 110);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(367, 328);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// createCustomBtn
			// 
			this.createCustomBtn.Location = new System.Drawing.Point(12, 44);
			this.createCustomBtn.Name = "createCustomBtn";
			this.createCustomBtn.Size = new System.Drawing.Size(75, 23);
			this.createCustomBtn.TabIndex = 1;
			this.createCustomBtn.Text = "新增客戶";
			this.createCustomBtn.UseVisualStyleBackColor = true;
			this.createCustomBtn.Click += new System.EventHandler(this.createCustomBtn_Click);
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerAddressDataGridViewTextBoxColumn
			// 
			this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
			this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
			this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
			this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerPhoneDataGridViewTextBoxColumn
			// 
			this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
			this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
			this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
			this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customersIndexVMBindingSource
			// 
			this.customersIndexVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomersIndexVM);
			// 
			// customersVMBindingSource1
			// 
			this.customersVMBindingSource1.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomersVM);
			// 
			// customersVMBindingSource
			// 
			this.customersVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomersVM);
			// 
			// deliveryVMBindingSource
			// 
			this.deliveryVMBindingSource.DataSource = typeof(ISpan.inventory.Models.ViewModels.DeliveryVM);
			// 
			// customersVMBindingSource2
			// 
			this.customersVMBindingSource2.DataSource = typeof(ISpan.inventory.Models.ViewModels.CustomersVM);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 450);
			this.Controls.Add(this.createCustomBtn);
			this.Controls.Add(this.dataGridView1);
			this.Name = "EditForm";
			this.Text = "EditForm";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deliveryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersVMBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource deliveryVMBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource customersVMBindingSource;
		private System.Windows.Forms.Button createCustomBtn;
		private System.Windows.Forms.BindingSource customersVMBindingSource1;
		private System.Windows.Forms.BindingSource customersVMBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource customersIndexVMBindingSource;
	}
}