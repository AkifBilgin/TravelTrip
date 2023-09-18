using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class Adresse
	{
		[Key]
		public int ID { get; set; }
		public string Uberschrift { get; set; }
		public string Inhalt { get; set; }
		public string Adrs { get; set; }
		public string Email { get; set; }
		public string Telefon { get; set; }
		public string Standort { get; set; }


	}
}