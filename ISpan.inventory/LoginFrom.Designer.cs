namespace ISpan.inventory
{
	partial class LoginFrom
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
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(185, 134);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "登入";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(89, 94);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(171, 22);
			this.passwordTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "密碼:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(89, 38);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(171, 22);
			this.accountTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "帳號:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// LoginFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 183);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "LoginFrom";
			this.Text = "登入系統";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}