using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class Kommentar
	{
		[Key]
			
		public int ID { get; set; }
		public string User { get; set; }
		public string Email { get; set; }
		public string Komment { get; set; }
		public int Blogid { get; set; }
		public virtual Blog Blog { get; set; }
	}
}