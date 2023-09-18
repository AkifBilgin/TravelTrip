using System.Linq;
using System.Web.Mvc;
using TravelTrip.Models.Entity;

namespace TravelTrip.Controllers
{
	public class AdminController : Controller
	{
		Context context = new Context();
		// GET: Admin
		[Authorize]
		public ActionResult Index()
		{
			var result = context.Blogs.ToList();
			return View(result);
		}
		[HttpGet]
		public ActionResult NeuerBlog()
		{
			return View();
		}
		[HttpPost]
		public ActionResult NeuerBLog(Blog blog)
		{
			context.Blogs.Add(blog);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult BlogLoschen(int id)
		{

			var result = context.Blogs.Find(id);
			context.Blogs.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult GetBlog(int id)
		{
			var result = context.Blogs.Find(id);
			return View("GetBLog", result);
		}
		[HttpPost]
		public ActionResult UpdateBlog(Blog blog)
		{
			var result = context.Blogs.Find(blog.ID);
			result.Uberschrift = blog.Uberschrift;
			result.Inhalt = blog.Inhalt;
			result.BlogImage = blog.BlogImage;
			result.Datum = blog.Datum;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult Kommentare() 
		{
			var result = context.Kommentars.ToList();
			return View(result);
		}
		public ActionResult DeleteComment(int id)
		{
			var result = context.Kommentars.Find(id);
			context.Kommentars.Remove(result);
			context.SaveChanges();
			return RedirectToAction("Kommentare");
		}
		public ActionResult GetComment(int id)
		{
			var result = context.Kommentars.Find(id);
			return View("GetComment",result);
		}
		[HttpPost]
		public ActionResult UpdateComment(Kommentar kommentar)
		{
			var result = context.Kommentars.Find(kommentar.ID);
			result.User = kommentar.User;
			result.Email = kommentar.Email;
			result.Komment = kommentar.Komment;
			context.SaveChanges();
			return RedirectToAction("Kommentare");
		}
	}
}