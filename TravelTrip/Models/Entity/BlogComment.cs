using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Entity
{
	public class BlogComment
	{
		public IEnumerable<Blog> P1 { get; set; }
		public IEnumerable<Kommentar> P2 { get; set; }
		public IEnumerable<Blog> P3 { get; set; }
	}
}