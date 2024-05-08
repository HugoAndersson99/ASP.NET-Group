using ASP.Net_GruppUPG.Objects;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_GruppUPG.Services
{
    public class MediaUserService
    {
        DatabaseContext db;
        static MediaUser choosenUser;

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
            bool emailExists = db.MediaUser.Any(m  => m.Email == mediaUser.Email);
            if (mediaUser == null || emailExists)
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
        public void SetUser(MediaUser user)
        {
            choosenUser = user;
        }

        public bool AddMovieToLibrary(Movie movie)
        {
            try
            {
                if (movie == null || choosenUser == null)
                {
                    return false;
                }

                //movie.Users.Add(choosenUser);

                //choosenUser.MoviesInLibrary.Add(movie);

                MediaUser userFromDb = db.MediaUser.Find(choosenUser.Id);
                Movie movieFromDb = db.Movie.Find(movie.MovieId);

                userFromDb.MoviesInLibrary.Add(movieFromDb);
                movieFromDb.Users.Add(userFromDb);
                
                int count = db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        public bool AddSerieToLibrary(Serie serie)
        {
            try
            {
                if (serie == null || choosenUser == null)
                {
                    return false;
                }

               // serie.Users.Add(choosenUser);
               //
               // choosenUser.SeriesInLibrary.Add(serie);

                MediaUser userFromDb = db.MediaUser.Find(choosenUser.Id);
                Serie serieFromDb = db.Serie.Find(serie.SerieId);
                userFromDb.SeriesInLibrary.Add(serieFromDb);

                serieFromDb.Users.Add(userFromDb);


                int count = db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveMovieFromLibrary(Movie movie)
        {
            try
            {
                if (choosenUser == null)
                {
                    return false;
                }

                // Ladda användaren inklusive dess relaterade filmer
                var userFromDb = db.MediaUser
                    .Include(u => u.MoviesInLibrary)
                    .FirstOrDefault(u => u.Id == choosenUser.Id);

                if (userFromDb != null)
                {
                    var movieToRemove = userFromDb.MoviesInLibrary.FirstOrDefault(m => m.MovieId == movie.MovieId);
                    if (movieToRemove != null)
                    {
                        userFromDb.MoviesInLibrary.Remove(movieToRemove);
                        db.SaveChanges();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveSerieFromLibrary(Serie serie)
        {
            try
            {
                if (choosenUser == null || serie == null)
                {
                    return false;
                }

                var userFromDb = db.MediaUser
                    .Include(u => u.SeriesInLibrary)
                    .FirstOrDefault(u => u.Id == choosenUser.Id);

                if (userFromDb != null)
                {
                    var serieToRemove = userFromDb.SeriesInLibrary.FirstOrDefault(s => s.SerieId == serie.SerieId);
                    if (serieToRemove != null)
                    {
                        userFromDb.SeriesInLibrary.Remove(serieToRemove);
                        db.SaveChanges();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void Save(Movie movie)
        {
            db.Movie.Add(movie);
            db.SaveChanges();
        }

        public List<Movie> GetUserMovies(int userId)
        {
            MediaUser user = db.MediaUser.Include(u => u.MoviesInLibrary).FirstOrDefault(u => u.Id == userId);


            if (user == null || user.MoviesInLibrary == null)
            {
                return new List<Movie>();
            }

            return user.MoviesInLibrary.ToList();
        }

        public List<Serie> GetUserSeries(int userId)
        {
            MediaUser user = db.MediaUser.Include(u => u.SeriesInLibrary).FirstOrDefault(u => u.Id == userId);


            if (user == null || user.SeriesInLibrary == null)
            {
                return new List<Serie>();
            }

            return user.SeriesInLibrary.ToList();
        }
    }
}
