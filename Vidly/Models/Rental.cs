using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Rental
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public Movie Movie { get; set; }

        public DateTime RentedDate { get; set; } = DateTime.Now;

        public DateTime? ReturnedDate { get; set; }

        public int CustomerId { get; set; }

        public int MovieId { get; set; }
    }
}