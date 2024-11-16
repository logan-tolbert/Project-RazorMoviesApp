namespace MovieApp.Models
{
    public interface IMovieModel
    {
        string? Title { get; set; }
        string? Genre { get; set; }
        string? Year { get; set; }
    }
}