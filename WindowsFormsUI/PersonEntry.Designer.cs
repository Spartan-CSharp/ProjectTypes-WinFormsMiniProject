namespace WindowsFormsUI
{
	partial class PersonEntry
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
			if ( disposing && (components != null) )
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
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.addressesLabel = new System.Windows.Forms.Label();
			this.addressesListBox = new System.Windows.Forms.ListBox();
			this.addAddressButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(50, 50);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
			this.firstNameLabel.TabIndex = 0;
			this.firstNameLabel.Text = "Fisrt Name";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(169, 47);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(150, 35);
			this.firstNameTextBox.TabIndex = 1;
			this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(325, 50);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
			this.lastNameLabel.TabIndex = 0;
			this.lastNameLabel.Text = "Last Name";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(445, 47);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(150, 35);
			this.lastNameTextBox.TabIndex = 2;
			this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
			// 
			// addressesLabel
			// 
			this.addressesLabel.AutoSize = true;
			this.addressesLabel.Location = new System.Drawing.Point(50, 110);
			this.addressesLabel.Name = "addressesLabel";
			this.addressesLabel.Size = new System.Drawing.Size(107, 30);
			this.addressesLabel.TabIndex = 2;
			this.addressesLabel.Text = "Addresses";
			// 
			// addressesListBox
			// 
			this.addressesListBox.FormattingEnabled = true;
			this.addressesListBox.ItemHeight = 30;
			this.addressesListBox.Location = new System.Drawing.Point(50, 143);
			this.addressesListBox.Name = "addressesListBox";
			this.addressesListBox.Size = new System.Drawing.Size(545, 184);
			this.addressesListBox.TabIndex = 3;
			// 
			// addAddressButton
			// 
			this.addAddressButton.Location = new System.Drawing.Point(230, 357);
			this.addAddressButton.Name = "addAddressButton";
			this.addAddressButton.Size = new System.Drawing.Size(185, 40);
			this.addAddressButton.TabIndex = 4;
			this.addAddressButton.Text = "Add Address";
			this.addAddressButton.UseVisualStyleBackColor = true;
			this.addAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
			// 
			// PersonEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 408);
			this.Controls.Add(this.addAddressButton);
			this.Controls.Add(this.addressesListBox);
			this.Controls.Add(this.addressesLabel);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "PersonEntry";
			this.Text = "Person Entry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label addressesLabel;
		private System.Windows.Forms.ListBox addressesListBox;
		private System.Windows.Forms.Button addAddressButton;
	}
}
