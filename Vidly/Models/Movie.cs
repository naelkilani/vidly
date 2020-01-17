using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AddedDate { get; set; } = DateTime.Now;
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
