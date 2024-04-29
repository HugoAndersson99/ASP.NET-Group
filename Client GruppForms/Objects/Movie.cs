namespace Client_GruppForms.Objects
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int LengthMin { get; set; }

        public Movie(int movieId, string title, string genre, string description, int releaseYear, int lengthMin)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            Description = description;
            ReleaseYear = releaseYear;
            LengthMin = lengthMin;
        }

        public Movie() { }
    }
}
