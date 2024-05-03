using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.Net_GruppUPG.Pages
{
    public class EditMovieModel : PageModel
    {
        private MovieService movieService;

        public EditMovieModel(MovieService movieService)
        {
            this.movieService = movieService;
        }
        [BindProperty]
        public Movie Movie { get; set; }



        public ActionResult OnGet(int movieId)
        {
            Movie = movieService.GetMovieById(movieId);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var success = movieService.EditMovie(Movie);
            if (!success)
            {
                return BadRequest();
            }
            return RedirectToPage("/Movies"); 
        }
    }
}
