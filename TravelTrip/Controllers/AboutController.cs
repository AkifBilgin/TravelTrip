using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Entity;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.UberUns.ToList();
            return View(result);
        }
    }
}