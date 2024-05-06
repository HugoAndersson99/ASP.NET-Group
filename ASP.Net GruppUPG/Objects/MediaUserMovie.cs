namespace ASP.Net_GruppUPG.Objects
{
    public class MediaUserMovie
    {
        public int MediaUserId { get; set; }
        public int MovieId { get; set; }

        public MediaUserMovie(int movieId, int userId)
        {
            MovieId = movieId;
            MediaUserId = userId;
        }
        public MediaUserMovie() { }
    }
}
