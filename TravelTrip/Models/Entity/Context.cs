using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TravelTrip.Models.Entity
{
	public class Context:DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Adresse> Adresses { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Kommentar> Kommentars { get; set; }
		public DbSet<Kontakt> Kontakts { get; set; }
		public DbSet<UberUns> UberUns { get; set; }
	}
}