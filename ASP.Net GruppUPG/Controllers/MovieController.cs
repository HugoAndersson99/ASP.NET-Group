using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_GruppUPG.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieService movieService;

        public MovieController(MovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet("all")]
        public List<Movie> GetAll()
        {
            return movieService.GetMovies();
        }

        [HttpGet("byid")]
        public Movie GetMovieById(int id)
        {
            return movieService.GetMovieById(id);
        }

        [HttpPost("add")]
        public ActionResult AddMovie(Movie movie)
        {
            bool success = movieService.AddMovie(movie);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("edit")]
        public ActionResult EditMovie(Movie movie)
        {
            bool success = movieService.EditMovie(movie);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public ActionResult DeleteMovie(int id)
        {
            bool success = movieService.DeleteMovieById(id);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
