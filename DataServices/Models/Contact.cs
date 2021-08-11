using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		//public Address Address { get; set; }
	}
}
