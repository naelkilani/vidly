using AutoMapper;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Dtos;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult New()
        {
            var viewModel = new MovieFormViewModel
            {
                MovieDto = new MovieDto(),
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                MovieDto = Mapper.Map<Movie, MovieDto>(movie),
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    MovieDto = movieDto,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movieDto.Id == 0)
                AddMovie(movieDto);
            else
                UpdateMovie(movieDto);

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        private void AddMovie(MovieDto movieDto)
        {
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            movieDto.Id = movie.Id;
        }

        private void UpdateMovie(MovieDto movieDto)
        {
            var movieInDb = _context.Movies.First(m => m.Id == movieDto.Id);
            Mapper.Map(movieDto, movieInDb);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}