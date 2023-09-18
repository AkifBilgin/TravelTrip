using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Entity;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogComment bc = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            //var result = context.Blogs.ToList();
            bc.P1 = context.Blogs.ToList();
            bc.P2 = context.Kommentars.Take(3).OrderByDescending(x=>x.ID).ToList();
            bc.P3 = context.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return View(bc);
        }
 
        public ActionResult BlogDetail(int id)
		{
            //var blog = context.Blogs.Where(x => x.ID == id).ToList();
            bc.P1 = context.Blogs.Where(x => x.ID == id).ToList();
            bc.P2 = context.Kommentars.Where(x => x.Blogid == id).Take(3).OrderByDescending(x=>x.ID).ToList();
            return View(bc); 
		}
        [HttpGet]
        public PartialViewResult Kommentieren(int id)
		{
            ViewBag.result = id;
            return PartialView();
		}

        [HttpPost]
        public PartialViewResult Kommentieren(Kommentar kommentar)
		{
            context.Kommentars.Add(kommentar);
            context.SaveChanges();
            return PartialView();

		}
    }
}