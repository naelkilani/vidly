﻿using Microsoft.Ajax.Utilities;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Shark" };
            return RedirectToAction("Index", "Home", new { Page = 1, SortBy = "name" });
        }

        public ActionResult Index(int? page, string sortBy)
        {
            if (!page.HasValue)
                page = 1;

            if (sortBy.IsNullOrWhiteSpace())
                sortBy = "name";

            return Content($"page = {page} & sortBy = {sortBy}");
        }
    }
}