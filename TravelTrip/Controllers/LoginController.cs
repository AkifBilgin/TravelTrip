using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip.Models.Entity;
namespace TravelTrip.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
		{
            return View();
		}
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.User == admin.User && x.Passwort == admin.Passwort);
            if(result != null)
			{
                FormsAuthentication.SetAuthCookie(result.User, false);
                Session["User"] = result.User.ToString();
                return RedirectToAction("Index", "Admin");

			}
			else
			{
                return View();
			}
        }
        public ActionResult Logout()
		{
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
		}
    }
}