using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomizedHelppage.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return Redirect("/Help/");
        }
    }
}