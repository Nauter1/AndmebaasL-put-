using ArtGallery.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace ArtGallery.Data
{
    public class ArtGalleryDbContext : DbContext
    {
        public ArtGalleryDbContext(DbContextOptions<ArtGalleryDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Artwork> Artwork { get; set; }
        public DbSet<DisplayDates> DisplayDates { get; set; }
        public DbSet<Exhibit> Exhibit { get; set; }
        public DbSet<Gallery> Gallery { get; set; }

    }
}
