using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int StockNumber { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
