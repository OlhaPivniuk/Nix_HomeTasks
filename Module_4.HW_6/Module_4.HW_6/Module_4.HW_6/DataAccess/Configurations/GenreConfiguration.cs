using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4.HW_6.Entities;

namespace Module_4.HW_6.DataAccess.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Genre
                {
                    Id = 1,
                    Title = "Rock"
                },
                new Genre
                {
                    Id = 2,
                    Title = "Pop"
                },
                new Genre
                {
                    Id = 3,
                    Title = "Rap"
                },
                new Genre
                {
                    Id = 4,
                    Title = "Blues"
                },
                new Genre
                {
                    Id = 5,
                    Title = "Shanson"
                },
                new Genre
                {
                    Id = 6,
                    Title = "Electronic"
                },
                new Genre
                {
                    Id = 7,
                    Title = "Reggae"
                });
        }
    }
}
