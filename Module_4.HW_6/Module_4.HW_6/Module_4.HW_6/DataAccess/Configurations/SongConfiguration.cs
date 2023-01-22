using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4.HW_6.Entities;

namespace Module_4.HW_6.DataAccess.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Duration).IsRequired().HasMaxLength(10);
            builder.Property(a => a.ReleaseDate).IsRequired().HasColumnType("date");

            builder.HasData(
                new Song
                {
                    Id = 1,
                    Title = "Something",
                    Duration = "3:07",
                    ReleaseDate = new DateTime(1969, 3, 3),
                    GenreId = 1
                },
                new Song
                {
                    Id = 2,
                    Title = "Hung Up",
                    Duration = "5:33",
                    ReleaseDate = new DateTime(2009, 10, 27),
                    GenreId = 2
                },
                new Song
                {
                    Id = 3,
                    Title = "Frozen",
                    Duration = "5:29",
                    ReleaseDate = new DateTime(2009, 10, 27),
                    GenreId = 2
                },
                new Song
                {
                    Id = 4,
                    Title = "Lose Yourself",
                    Duration = "5:23",
                    ReleaseDate = new DateTime(2002, 3, 3),
                    GenreId = 3
                },
                new Song
                {
                    Id = 5,
                    Title = "Mockingbird",
                    Duration = "4:17",
                    ReleaseDate = new DateTime(2004, 8, 22),
                    GenreId = 3
                },
                new Song
                {
                    Id = 6,
                    Title = "Vladimir Central",
                    Duration = "4:27",
                    ReleaseDate = new DateTime(1998, 6, 15),
                    GenreId = 5
                },
                new Song
                {
                    Id = 7,
                    Title = "The Thrill Is Gone",
                    Duration = "11:05",
                    ReleaseDate = new DateTime(1993, 5, 20),
                    GenreId = 4
                },
                new Song
                {
                    Id = 8,
                    Title = "Wake Me Up",
                    Duration = "4:32",
                    ReleaseDate = new DateTime(2013, 7, 29),
                    GenreId = 6
                },
                new Song
                {
                    Id = 9,
                    Title = "No Woman, No Cry",
                    Duration = "7:10",
                    ReleaseDate = new DateTime(1999, 3, 15),
                    GenreId = 7
                },
                new Song
                {
                    Id = 10,
                    Title = "Na Zare",
                    Duration = "5:56",
                    ReleaseDate = new DateTime(1987, 3, 22),
                    GenreId = 1
                });
        }
    }
}
