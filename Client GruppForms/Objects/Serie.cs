using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_GruppForms.Objects
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string Title { get; set;}
        public string Description { get; set;}
        public int ReleaseYear { get; set; }
        public int Episodes { get; set; }
        public int Seasons { get; set; }
        public List<MediaUser> Users { get; set; }

        public Serie(int serieId, string title, string description, int releaseYear, int episodes, int seasons)
        {
            SerieId = serieId;
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Episodes = episodes;
            Seasons = seasons;
        }
        public Serie() { }
    }
}
