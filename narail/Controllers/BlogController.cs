using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace narail.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "Blog";
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Popular()
        {
            return View();
        }

        public ActionResult Tag()
        {
            return View();
        }

    }
}