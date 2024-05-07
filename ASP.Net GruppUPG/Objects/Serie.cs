using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
namespace ASP.Net_GruppUPG.Objects
{
    public class Serie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SerieId { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(225)]
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int Episodes { get; set; }
        public int Seasons { get; set; }
        public List<MediaUser> Users { get; set; } = new List<MediaUser>();

        public Serie (int serieId, string title, string description, int releaseYear, int episodes, int seasons)
        {
            SerieId = serieId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Episodes = episodes;
            Seasons = seasons;
        }
        public Serie(string title, string description, int releaseYear, int episodes, int seasons)
        {

            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Episodes = episodes;
            Seasons = seasons;
        }
        public Serie() { }
    }
}
