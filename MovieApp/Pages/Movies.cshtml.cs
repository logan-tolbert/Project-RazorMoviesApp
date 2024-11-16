using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieApp.Models;
using MovieApp.Repository;

namespace MovieApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<MovieModel> Movies = MovieRepo.Movies;
        
        public void OnGet()
        {
        
        }
    }
}
