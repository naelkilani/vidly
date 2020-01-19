using System.Collections.Generic;
using Vidly.Models;
using Vidly.ModelsDtos;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieDto MovieDto { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public string Title => MovieDto == null ? "New Movie" : "Edit Movie";

    }
}