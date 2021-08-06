﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactManager.Controllers
{
	//NOTE: DA - I would normally encourage the use of request/response objects but, this is omitted for simplicity

	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		// GET: api/<ContactController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			string MyString = "abc";

			return new string[] { "value1", "value2" };
		}

		// GET api/<ContactController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ContactController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ContactController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ContactController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}