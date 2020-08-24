using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net_movie_rental_project.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
