using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

namespace WindowsFormsUI
{
	public partial class AddressEntry : Form
	{
		private readonly ISaveAddress _parent;
		private readonly AddressModel _addressModel = new AddressModel();

		public AddressEntry(ISaveAddress parent, string personName)
		{
			InitializeComponent();

			personLabel.Text = personName;
			_parent = parent;

		}

		private void SaveAddressButton_Click(object sender, EventArgs e)
		{
			_addressModel.StreetAddress = streetAddressTextBox.Text;
			_addressModel.City = cityTextBox.Text;
			_addressModel.State = stateTextBox.Text;
			_addressModel.ZipCode = zipCodeTextBox.Text;

			_parent.SaveAddress(_addressModel);

			Close();
		}
	}
}
