namespace ClassLibrary
{
	public class AddressModel
	{
		public string StreetAddress
		{
			get; set;
		}

		public string City
		{
			get; set;
		}

		public string State
		{
			get; set;
		}

		public string ZipCode
		{
			get; set;
		}

		public string FormattedAddress
		{
			get
			{
				return $"{StreetAddress}, {City} {State} {ZipCode}";
			}
		}
	}
}
