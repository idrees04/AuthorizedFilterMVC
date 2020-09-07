using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizedFilterMVC.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        // [AllowAnonymous] filter mean everybody can access this  view this method will work with [Authorize] filter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        
        public ActionResult Contact()
        {
            return View();
        }
    }
}

