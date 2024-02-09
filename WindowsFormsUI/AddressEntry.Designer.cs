namespace WindowsFormsUI
{
	partial class AddressEntry
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
			this.streetAddressLabel = new System.Windows.Forms.Label();
			this.streetAddressTextBox = new System.Windows.Forms.TextBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.stateLabel = new System.Windows.Forms.Label();
			this.zipCodeLabel = new System.Windows.Forms.Label();
			this.stateTextBox = new System.Windows.Forms.TextBox();
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.saveAddressButton = new System.Windows.Forms.Button();
			this.personLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// streetAddressLabel
			// 
			this.streetAddressLabel.AutoSize = true;
			this.streetAddressLabel.Location = new System.Drawing.Point(50, 110);
			this.streetAddressLabel.Name = "streetAddressLabel";
			this.streetAddressLabel.Size = new System.Drawing.Size(146, 30);
			this.streetAddressLabel.TabIndex = 0;
			this.streetAddressLabel.Text = "Street Address";
			// 
			// streetAddressTextBox
			// 
			this.streetAddressTextBox.Location = new System.Drawing.Point(202, 107);
			this.streetAddressTextBox.Name = "streetAddressTextBox";
			this.streetAddressTextBox.Size = new System.Drawing.Size(300, 35);
			this.streetAddressTextBox.TabIndex = 1;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(50, 170);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(48, 30);
			this.cityLabel.TabIndex = 0;
			this.cityLabel.Text = "City";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(202, 167);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(300, 35);
			this.cityTextBox.TabIndex = 2;
			// 
			// stateLabel
			// 
			this.stateLabel.AutoSize = true;
			this.stateLabel.Location = new System.Drawing.Point(50, 230);
			this.stateLabel.Name = "stateLabel";
			this.stateLabel.Size = new System.Drawing.Size(59, 30);
			this.stateLabel.TabIndex = 0;
			this.stateLabel.Text = "State";
			// 
			// zipCodeLabel
			// 
			this.zipCodeLabel.AutoSize = true;
			this.zipCodeLabel.Location = new System.Drawing.Point(50, 290);
			this.zipCodeLabel.Name = "zipCodeLabel";
			this.zipCodeLabel.Size = new System.Drawing.Size(96, 30);
			this.zipCodeLabel.TabIndex = 0;
			this.zipCodeLabel.Text = "Zip Code";
			// 
			// stateTextBox
			// 
			this.stateTextBox.Location = new System.Drawing.Point(202, 227);
			this.stateTextBox.Name = "stateTextBox";
			this.stateTextBox.Size = new System.Drawing.Size(300, 35);
			this.stateTextBox.TabIndex = 3;
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.Location = new System.Drawing.Point(202, 287);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.Size = new System.Drawing.Size(300, 35);
			this.zipCodeTextBox.TabIndex = 4;
			// 
			// saveAddressButton
			// 
			this.saveAddressButton.Location = new System.Drawing.Point(202, 350);
			this.saveAddressButton.Name = "saveAddressButton";
			this.saveAddressButton.Size = new System.Drawing.Size(300, 40);
			this.saveAddressButton.TabIndex = 5;
			this.saveAddressButton.Text = "Save && Add";
			this.saveAddressButton.UseVisualStyleBackColor = true;
			this.saveAddressButton.Click += new System.EventHandler(this.SaveAddressButton_Click);
			// 
			// personLabel
			// 
			this.personLabel.AutoSize = true;
			this.personLabel.Location = new System.Drawing.Point(50, 50);
			this.personLabel.Name = "personLabel";
			this.personLabel.Size = new System.Drawing.Size(135, 30);
			this.personLabel.TabIndex = 6;
			this.personLabel.Text = "<Full Name>";
			// 
			// AddressEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 401);
			this.Controls.Add(this.personLabel);
			this.Controls.Add(this.saveAddressButton);
			this.Controls.Add(this.zipCodeTextBox);
			this.Controls.Add(this.stateTextBox);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.zipCodeLabel);
			this.Controls.Add(this.streetAddressTextBox);
			this.Controls.Add(this.stateLabel);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.streetAddressLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "AddressEntry";
			this.Text = "Address Entry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label streetAddressLabel;
		private System.Windows.Forms.TextBox streetAddressTextBox;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label stateLabel;
		private System.Windows.Forms.Label zipCodeLabel;
		private System.Windows.Forms.TextBox stateTextBox;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.Button saveAddressButton;
		private System.Windows.Forms.Label personLabel;
	}
}