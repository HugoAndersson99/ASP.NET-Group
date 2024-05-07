using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.Net_GruppUPG.Objects
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Genre { get; set; }
        [MaxLength(225)]
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int LengthMin { get; set; }

        //public Image CoverImage { get; set; }

        public List<MediaUser> Users { get; set; } = new List<MediaUser>();

        public Movie(int movieId, string title, string genre, string description, int releaseYear, int lengthMin)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            Description = description;
            ReleaseYear = releaseYear;
            LengthMin = lengthMin;
        }
        public Movie(string title, string genre, string description, int releaseYear, int lengthMin)
        {
            Title = title;
            Genre = genre;
            Description = description;
            ReleaseYear = releaseYear;
            LengthMin = lengthMin;
        }

        public Movie() { }
    }
}
