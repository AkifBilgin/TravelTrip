using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class Kontakt
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Telefon { get; set; }
		public string Betreff { get; set; }
		public string Message { get; set; }
	}
}