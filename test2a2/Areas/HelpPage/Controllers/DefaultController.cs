using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2a2.Areas.HelpPage.Controllers
{
    public class DefaultController : Controller
    {
        // GET: HelpPage/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}