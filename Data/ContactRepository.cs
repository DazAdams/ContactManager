using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
	public class ContactRepository //: IContactRepository
	{
		private ContactManagerContext _entities;

		public ContactRepository(ContactManagerContext entities)
		{
			_entities = entities;
		}

		public Contact GetContact(int ContactId)
		{
			return _entities.Contacts.FirstOrDefault(x => x.ContactId == ContactId);
		}

		public IEnumerable<Contact> GetContacts()
		{
			return _entities.Contacts.ToList();
		}

		public void SaveChanges()
		{
			//NOTE: DA - Should ideally return a response indicating success/fail etc.
			_entities.SaveChanges();
		}

		public void SaveContact(Contact Contact)
		{
			_entities.Add(Contact);
		}

	}
}
