using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class Start
	{
		[Key]
		public int ID { get; set; }
		public string Uberschrift { get; set; }
		public string Inhalt { get; set; }
	}
}