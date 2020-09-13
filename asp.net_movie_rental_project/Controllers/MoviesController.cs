using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp.net_movie_rental_project.Models;

namespace asp.net_movie_rental_project.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            Movie movie = new Movie() { name = "Under Siege", id = 1 };
            return  View(movie);
        }

    }
}
