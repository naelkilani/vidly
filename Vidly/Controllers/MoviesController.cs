﻿using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Shark" };
            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;

            return View();
        }
    }
}