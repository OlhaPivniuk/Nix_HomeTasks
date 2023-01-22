using Microsoft.EntityFrameworkCore;
using Module_4.HW_6.DataAccess.Configurations;
using Module_4.HW_6.Entities;

namespace Module_4.HW_6.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<SongArtist> SongArtist { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new SongArtistConfiguration());
        }
    }
}
