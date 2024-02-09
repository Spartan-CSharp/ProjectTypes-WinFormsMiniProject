using System.Collections.Generic;

namespace ClassLibrary
{
	public class PersonModel
	{
		public string FirstName
		{
			get; set;
		}

		public string LastName
		{
			get; set;
		}

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public List<AddressModel> Addresses
		{
			get; set;
		} = new List<AddressModel>();
	}
}
