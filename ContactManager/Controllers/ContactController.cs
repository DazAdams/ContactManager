using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;
using System.Collections.Generic;

namespace ContactManager.Controllers
{
	//NOTE: DA - I would normally encourage the use of request/response objects but, this is omitted for simplicity
	[Produces("application/json")]
	[Route("api/contacts")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet]
		public IEnumerable<Contact> Get()
		{
			return _contactService.GetContacts();
		}

		[HttpGet("{id}")]
		public Contact Get(int id)
		{
			return _contactService.GetContact(id);
		}

		[HttpPost]
		public void Post([FromBody] Contact contact)
		{
			_contactService.SaveContact(contact);
		}

		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value)
		//{
		//}

		//[HttpDelete("{id}")]
		//public void Delete(int id)
		//{
		//}
	}
}
