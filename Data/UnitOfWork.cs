using Data;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
	public class UnitOfWork
	{
		private ContactRepository _contactRepository;
		private ContactManagerContext _contacts;

		public UnitOfWork(ContactManagerContext contacts)
		{
			_contacts = contacts;
		}

		public ContactRepository ContactRepository
		{
			get
			{
				if (_contactRepository == null)
				{
					_contactRepository = new ContactRepository(_contacts);
				}
				return _contactRepository;
			}

		}

		public void Save()
		{
			_contacts.SaveChanges();
		}
	}
}
