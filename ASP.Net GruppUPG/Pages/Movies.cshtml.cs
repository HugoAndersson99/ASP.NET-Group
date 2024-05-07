using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASP.Net_GruppUPG.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly MovieService _movieService;

        public MoviesModel(MovieService movieService)
        {
            _movieService = movieService;
        }

        public List<Movie> movies { get; set; }

        [BindProperty]
        public Movie NewMovie { get; set; }


        public void OnGet()
        {
            
            movies = _movieService.GetMovies();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid && _movieService.AddMovie(NewMovie))
            {
                return RedirectToPage();
            }
            return RedirectToPage("ErrorPage");
        }

        public IActionResult OnPostDelete(int movieId)
        {
           
            var result = _movieService.DeleteMovieById(movieId);
            if (!result)
            {
               return NotFound();
            }
            return RedirectToPage();

        }
    }
}
