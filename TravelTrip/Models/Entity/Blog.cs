using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class Blog
	{
		[Key]
		public int ID { get; set; }
		public string Uberschrift { get; set; }
		public DateTime Datum { get; set; }
		public string Inhalt { get; set; }
		public string BlogImage { get; set; }
		public ICollection<Kommentar> Kommentars { get; set; }
		public bool Top { get; set; }

	}
}