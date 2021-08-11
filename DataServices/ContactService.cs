using Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
	public class ContactService : IContactService
	{
		UnitOfWork _unitOfWork = new UnitOfWork(new Data.ContactManagerContext());
		public Contact GetContact(int ContactId)
		{
			var result = _unitOfWork.ContactRepository.GetContact(ContactId);

			var contact = result == null ? new Contact() :
				new Contact
				{
					ContactId = result.ContactId,
					Email = result.EmailAddress,
					Firstname = result.Firstname,
					Lastname = result.Lastname,
					Phone = result.Phone
				};

			return contact;
		}

		public List<Contact> GetContacts()
		{
			var result = _unitOfWork.ContactRepository.GetContacts();

			var contacts = result.Select(x => new Contact
			{
				ContactId = x.ContactId,
				Email = x.EmailAddress,
				Firstname = x.Firstname,
				Lastname = x.Lastname,
				Phone = x.Phone
			});

			return contacts.ToList();
		}

		public void SaveContact(Contact Contact)
		{
			_unitOfWork.ContactRepository.SaveContact(new Data.Contact
			{
				ContactId = Contact.ContactId,
				Firstname = Contact.Firstname,
				Lastname = Contact.Lastname,
				Phone = Contact.Phone,
				EmailAddress = Contact.Email
			});

			_unitOfWork.Save();
		}
	}
}
