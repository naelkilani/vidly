using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Post(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.First(c => c.Id == newRentalDto.CustomerId);

            var movies = _context.Movies
                .Where(m => newRentalDto.MovieIds.Contains(m.Id))
                .ToList();

            foreach (var movie in movies)
            {
                if (movie.AvailableNumber == 0)
                    return BadRequest($"Movie ID: {movie.Id}, Name: {movie.Name} isn't available currently in the Rental.");

                _context.Rentals.Add(new Rental
                {
                    Customer = customer,
                    Movie = movie
                });

                movie.AvailableNumber--;
            }

            _context.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}