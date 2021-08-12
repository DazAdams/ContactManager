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
			// Check if we are adding or editing
			if (Contact.ContactId == 0)
			{
				_entities.Add(Contact);
			}
			else
			{
				var existingContact = _entities.Contacts.FirstOrDefault(x => x.ContactId == Contact.ContactId);
				existingContact.Firstname = Contact.Firstname;
				existingContact.Lastname = Contact.Lastname;
				existingContact.EmailAddress = Contact.EmailAddress;
				existingContact.Phone = Contact.Phone;
			}
			
		}

	}
}
