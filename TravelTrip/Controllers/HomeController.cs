using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Entity;
namespace TravelTrip.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Blogs.Take(5).OrderByDescending(x => x.ID).ToList();
            return View(result);
        }
        public PartialViewResult Partial1()
		{
            var result = context.Blogs.Take(2).OrderByDescending(x=>x.ID).ToList();
            return PartialView(result);
		}
        
        public PartialViewResult Partial2()
		{
            var result = context.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(result);
		}
            
        public PartialViewResult Partial3()
		{
            var result = context.Blogs.Take(10).OrderByDescending(x => x.ID).ToList();
            return PartialView(result);
		}
        public PartialViewResult Partial4()
		{
            var blog = context.Blogs.Take(3).OrderBy(x=>x.Top==true).ToList();
         
            return PartialView(blog);
		}
        public PartialViewResult Partial5()
        {
            var blog = context.Blogs.Where(x=>x.Top==true).OrderByDescending(x=>x.ID).Take(3).ToList();

            return PartialView(blog);
        }
    }
}