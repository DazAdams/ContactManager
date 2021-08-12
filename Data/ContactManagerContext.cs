using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
	public class ContactManagerContext : DbContext
	{
		public string DbPath { get; }

		// DbSets
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Address> Addresses { get; set; }

		public ContactManagerContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}contactmanager.db";
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
				 => options.UseSqlite($"Data Source={DbPath}");
	}
}
