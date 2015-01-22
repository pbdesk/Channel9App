using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PBDesk.Channel9.Web.Controllers
{
    public class AdminController : Controller
    {
		// GET: Admin
		[Authorize]
		public ActionResult Index()
        {
            return View();
        }
    }
}