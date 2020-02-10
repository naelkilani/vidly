using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string Name { get; set; }

        [Range(1, 20)]
        public int StockNumber { get; set; }

        public int AvailableNumber { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public Genre Genre { get; set; }

        public int GenreId { get; set; }
    }
}
