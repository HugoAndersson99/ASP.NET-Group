using Microsoft.EntityFrameworkCore;

namespace ASP.Net_GruppUPG.Objects
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Serie> Serie { get; set; }

        public DbSet<MediaUser> MediaUser { get; set; }

        public DbSet<Movie> Movie { get; set; }

   


    }
}
