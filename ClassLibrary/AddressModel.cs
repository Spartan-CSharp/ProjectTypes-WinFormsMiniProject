﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
