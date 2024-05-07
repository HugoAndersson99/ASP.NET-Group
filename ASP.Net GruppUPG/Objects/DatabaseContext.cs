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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definiera eventuella konfigurationer eller relationsdefinitioner här
            // Exempel:
            object value = modelBuilder.Entity<MediaUser>()
                .HasMany(u => u.MoviesInLibrary)
                .WithMany(m => m.Users);
                
                

            // Du kan också definiera konventioner eller annat här, om det behövs
        }


    }
}
