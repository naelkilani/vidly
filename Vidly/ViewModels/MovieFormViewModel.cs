using System.Collections.Generic;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieDto MovieDto { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public string Title => MovieDto != null && MovieDto.Id != 0 ? "Edit Movie" : "New Movie";

    }
}