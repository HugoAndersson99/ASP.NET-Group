using ASP.Net_GruppUPG.Objects;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_GruppUPG.Services
{
    public class MovieService
    {
        DatabaseContext db;

        public MovieService(DatabaseContext db)
        {
            this.db = db;
        }
        public List<Movie> GetMovies()
        {
            return db.Movie.Include(movie => movie.Users).ToList();

        }

        public Movie GetMovieById(int id)
        {
            return db.Movie.Find(id);
        }

        public bool AddMovie(Movie movie)
        {
            bool titleExists = db.Movie.Any(m  => m.Title == movie.Title);
            if (movie.Title == "" || titleExists)
            {
                return false;
            }
            db.Movie.Add(movie);
            db.SaveChanges();
            return true;
        }

        public bool DeleteMovieById(int id)
        {
            Movie movieToDelete = db.Movie.Find(id);
            if (movieToDelete == null)
            {
                return false;
            }
            db.Movie.Remove(movieToDelete);
            db.SaveChanges();
            return true;
        }

        public bool EditMovie(Movie movie)
        {
            if (movie.Title == null)
            {
                return false;
            }
            Movie movieToEdit = db.Movie.Find(movie.MovieId);
            if (movieToEdit == null)
            {
                return false;
            }
            movieToEdit.Title = movie.Title;
            movieToEdit.Genre = movie.Genre;
            movieToEdit.Description = movie.Description;
            movieToEdit.ReleaseYear = movie.ReleaseYear;
            movieToEdit.LengthMin = movie.LengthMin;
            db.SaveChanges();
            return true;
        }
    }
}
