using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class UberUns
	{
		[Key]
		public int ID { get; set; }
		public string FotoUrl { get; set; }
		public string Inhalt { get; set; }
	}
}