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
            if (!_context.Customers.Any(c => c.Id == newRentalDto.CustomerId))
                return BadRequest();

            if (newRentalDto.MovieIds.Any(id => !_context.Movies.Any(m => m.Id == id)))
                return BadRequest();
            
            foreach (var movieId in newRentalDto.MovieIds)
            {
                _context.Rentals.Add(new Rental
                {
                    CustomerId = newRentalDto.CustomerId,
                    MovieId = movieId
                });
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