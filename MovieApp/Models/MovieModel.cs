using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class MovieModel : IMovieModel
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Genre { get; set; }
        public MovieModel(string title, string year, string genre)
        {

            Title = title;
            Year = year;
            Genre = genre;
        }
    }
}
