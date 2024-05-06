using ASP.Net_GruppUPG.Objects;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_GruppUPG.Services
{
    public class SerieService
    {
        DatabaseContext db;
        public SerieService(DatabaseContext db)
        {
            this.db = db;
        }
        public List<Serie> GetSeries()
        {
            return db.Serie.Include(serie => serie.Users).ToList();
        }

        public Serie GetSerieById(int id)
        {
            return db.Serie.Find(id);
        }

        public bool AddSerie(Serie serie)
        {
            if (serie.Title == null)
            {
                return false;
            }

            db.Serie.Add(serie);
            db.SaveChanges();
            return true;
        }

        public bool EditSerie(Serie serie)
        {
            if (serie.Title == null)
            {
                return false;
            }
            Serie serieToUpdate = db.Serie.Find(serie.SerieId);
            if (serieToUpdate == null)
            {
                return false;
            }
            serieToUpdate.Title = serie.Title;
            serieToUpdate.Episodes = serie.Episodes;
            serieToUpdate.ReleaseYear = serie.ReleaseYear;
            serieToUpdate.Description = serie.Description;
            serieToUpdate.Seasons = serie.Seasons;
            db.SaveChanges();
            return true;
        }

        public bool DeleteSerieById(int id)
        {
            Serie serieToDelete = db.Serie.Find(id);
            if (serieToDelete == null)
            {
                return false;
            }
            db.Serie.Remove(serieToDelete);
            db.SaveChanges();
            return true;
        }
    }
}
