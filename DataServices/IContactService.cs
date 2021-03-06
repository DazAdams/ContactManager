
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
	// NOTE: DA - I would not normally advise directly passing data entities back through layers however, for the sake of simplicity....
	public interface IContactService
	{
		public Contact GetContact(int ContactId);
		public void SaveContact(Contact Contact);
		public List<Contact> GetContacts();
	}
}

