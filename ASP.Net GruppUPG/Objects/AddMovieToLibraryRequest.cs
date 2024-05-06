namespace ASP.Net_GruppUPG.Objects
{
    public class AddMovieToLibraryRequest
    {
        public Movie Movie { get; set; }
        public MediaUser MediaUser { get; set; }

        public AddMovieToLibraryRequest(Movie movie, MediaUser mediaUser)
        {
            Movie = movie;
            MediaUser = mediaUser;
        }
    }
}
