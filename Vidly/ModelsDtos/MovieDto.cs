using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ModelsDtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Number in Stock")]
        public int StockNumber { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

    }
}