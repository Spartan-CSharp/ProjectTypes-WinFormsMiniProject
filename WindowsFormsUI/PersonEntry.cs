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
	public partial class PersonEntry : Form, ISaveAddress
	{
		private string _firstName = "";
		private string _lastName = "";
		private readonly BindingList<AddressModel> _addressList = new BindingList<AddressModel>();
		private readonly PersonModel _person = new PersonModel();

		public PersonEntry()
		{
			InitializeComponent();
			WireUpLists();
		}

		private void WireUpLists()
		{
			firstNameTextBox.Text = _firstName;
			lastNameTextBox.Text = _lastName;
			addressesListBox.DataSource = _addressList;
			addressesListBox.DisplayMember = nameof(AddressModel.FormattedAddress);
		}

		private void AddAddressButton_Click(object sender, EventArgs e)
		{
			AddressEntry addressentry = new AddressEntry(this, _person.FullName);
			addressentry.Show();
		}

		public void SaveAddress(AddressModel address)
		{
			_addressList.Add(address);
			_person.Addresses.Add(address);
		}

		private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
		{
			_firstName = firstNameTextBox.Text;
			_person.FirstName = _firstName;
		}

		private void LastNameTextBox_TextChanged(object sender, EventArgs e)
		{
			_lastName = lastNameTextBox.Text;
			_person.LastName = _lastName;
		}
	}
}
