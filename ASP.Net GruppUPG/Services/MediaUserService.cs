using ASP.Net_GruppUPG.Objects;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_GruppUPG.Services
{
    public class MediaUserService
    {
        DatabaseContext db;
        

        public MediaUserService(DatabaseContext db)
        {
            this.db = db;
        }

        public List<MediaUser> GetMediaUsers()
        {
            return db.MediaUser.Include(mediaUser => mediaUser.SeriesInLibrary).Include(mediaUser => mediaUser.MoviesInLibrary).ToList();
        }
        
        public MediaUser GetMediaUserById(int id) 
        {
            return db.MediaUser.Find(id);
        }

        public bool DeleteMediaUserById(int id)
        {
            MediaUser userToDelete = db.MediaUser.Find(id);
            if (userToDelete == null)
            {
                return false;
            }
            db.MediaUser.Remove(userToDelete);
            db.SaveChanges();
            return true;
        }

        public bool AddMediaUser(MediaUser mediaUser)
        {
            if (mediaUser == null)
            {
                return false;
            }
            db.MediaUser.Add(mediaUser);
            db.SaveChanges();
            return true;
        }

        public bool UpdateMediaUser(MediaUser mediaUser)
        {
            if (mediaUser == null)
            {
                return false;
            }
            MediaUser userToUpdate = db.MediaUser.Find(mediaUser.Id);
            if (userToUpdate == null)
            {
                return false;
            }
            userToUpdate.FirstName = mediaUser.FirstName;
            userToUpdate.LastName = mediaUser.LastName;
            userToUpdate.Email = mediaUser.Email;
            userToUpdate.Password = mediaUser.Password;
            db.SaveChanges();
            return true;
        }

        public bool AddMovieToLibrary(Movie movie, MediaUser mediaUser)
        {

           // try
           // {
           //     Movie movie = db.Movie.Find(movieId);
           //     MediaUser user = db.MediaUser.Find(userId);
           //
           //     if (movie == null || user == null)
           //     {
           //         return false; 
           //     }
           //
           //     
           //         // Add mediaUser to the movie's Users list
           //        // movie.Users.Add(user);
           //
           //         // Add movie to mediaUser's MoviesInLibrary list
           //         //user.MoviesInLibrary.Add(movie);
           //     List<Movie> movies = new List<Movie>();
           //     movies.Add(movie);
           //     foreach(Movie addMovie in movies)
           //     {
           //         user.MoviesInLibrary.Add(addMovie);
           //     }
           //
           //         // Save changes to the database
           //         db.SaveChanges();
           //     
           //     return true;
           // }
           // catch (Exception ex)
           // {
           //     return false;
           // }

           //try
           //{
           //    var user = db.MediaUser
           //        .Include(u => u.MoviesInLibrary)
           //        .FirstOrDefault(u => u.Id == userId);
           //
           //    var movie = db.Movie.Find(movieId);
           //
           //    if (user == null || movie == null)
           //    {
           //        return false; // Invalid user or movie ID
           //    }
           //
           //    // Check if the movie is already in the user's library
           //    if (!user.MoviesInLibrary.Any(m => m.MovieId == movieId))
           //    {
           //        var userMovie = new MediaUserMovie { MediaUserId = userId, MovieId = movieId };
           //        db.MediaUserMovies.Add(userMovie);
           //        db.SaveChanges();
           //    }
           //
           //    return true; // Movie added successfully
           //}
           //catch (Exception ex)
           //{
           //    // Log or handle the exception
           //    return false; // Failed to add movie
           //}
            try
            {
                if (movie == null || mediaUser == null)
                {
                    return false;
                }
            
                if (!mediaUser.MoviesInLibrary.Any(m => m.MovieId == movie.MovieId))
                {
                    //MediaUser user = db.MediaUser.Find(mediaUser.Id);
                    //Movie updateMovie = db.Movie.Find(movie.MovieId);
                    
                    movie.Users.Add(mediaUser);
                    mediaUser.MoviesInLibrary.Add(movie);
                    //MediaUserMovie mediaUserMovie = new MediaUserMovie(movie.MovieId, mediaUser.Id);
                    //db.MediaUserMovie.Add(mediaUserMovie);

                    /*int changesSaved = */db.SaveChanges();
                    //if (changesSaved > 0)
                    //{
                    //    //Saved
                    //}
                    //else
                    //{
                    //    //Nothing saved
                    //}
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            //if (movie == null)
            //{
            //    return false;
            //}
            //mediaUser.MoviesInLibrary.Add(movie);
            //movie.Users.Add(mediaUser);
            //db.SaveChanges();
            //return true;

        }
    }
}
