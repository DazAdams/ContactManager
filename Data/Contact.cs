namespace Data
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string EmailAddress { get; set; }
		public string Phone { get; set; }

		public Address Address { get; set; }
		//Address type used to potentially allow for multiple addresses
	}
}
