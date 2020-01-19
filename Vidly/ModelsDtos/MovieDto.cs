using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ModelsDtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string Name { get; set; }

        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int StockNumber { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}