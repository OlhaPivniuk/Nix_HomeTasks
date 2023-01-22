using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4.HW_6.Entities;

namespace Module_4.HW_6.DataAccess.Configurations
{
    class SongArtistConfiguration : IEntityTypeConfiguration<SongArtist>
    {
        public void Configure(EntityTypeBuilder<SongArtist> builder)
        {
            builder.HasData(
                new SongArtist { Id = 1, ArtistId = 1, SongId = 1 },
                new SongArtist { Id = 2, ArtistId = 2, SongId = 2 },
                new SongArtist { Id = 3, ArtistId = 2, SongId = 3 },
                new SongArtist { Id = 4, ArtistId = 3, SongId = 4 },
                new SongArtist { Id = 5, ArtistId = 3, SongId = 5 },
                new SongArtist { Id = 6, ArtistId = 4, SongId = 7 },
                new SongArtist { Id = 7, ArtistId = 5, SongId = 6 },
                new SongArtist { Id = 8, ArtistId = 6, SongId = 8 },
                new SongArtist { Id = 9, ArtistId = 7, SongId = 9 },
                new SongArtist { Id = 10, ArtistId = 7, SongId = 10 },
                new SongArtist { Id = 11, ArtistId = 7, SongId = 10 });
        }
    }
}
