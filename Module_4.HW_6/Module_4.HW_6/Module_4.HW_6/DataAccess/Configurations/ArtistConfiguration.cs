using Module_4.HW_6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module_4.HW_6.DataAccess.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.DateOfBirth).IsRequired();

            builder.HasData(
                new Artist
                {
                    Id = 1,
                    Name = "The Beatles",
                    DateOfBirth = new DateTime(1960, 1, 1),
                    Phone = "+180115438829",
                    Email = "Beatles@gmail.com",
                    InstagramUrl = "@thebeatles"
                },
                new Artist
                {
                    Id = 2,
                    Name = "Madonna",
                    DateOfBirth = new DateTime(1958, 8, 16),
                    Phone = "+180115438816",
                    Email = "Madonna@gmail.com",
                    InstagramUrl = "@madonna"
                },
                new Artist
                {
                    Id = 3,
                    Name = "Eminem",
                    DateOfBirth = new DateTime(1972, 10, 17),
                    Phone = "+180253246628",
                    Email = "eminem@gmail.com",
                    InstagramUrl = "@eminem"
                },
                new Artist
                {
                    Id = 4,
                    Name = "B.B.King",
                    DateOfBirth = new DateTime(1925, 9, 16),
                    Phone = "+120863544495",
                    Email = "BBKing@gmail.com",
                    InstagramUrl = "@B.B.King"
                },
                new Artist
                {
                    Id = 5,
                    Name = "Mihail Krug",
                    DateOfBirth = new DateTime(1962, 4, 7),
                    Phone = "+780779379992",
                    Email = "Krug@gmail.com",
                    InstagramUrl = "@MKrug"
                },
                new Artist
                {
                    Id = 6,
                    Name = "Avicii",
                    DateOfBirth = new DateTime(1989, 9, 8),
                    Phone = "+180662354489",
                    Email = "avicii@gmail.com",
                    InstagramUrl = "@avicii"
                },
                new Artist
                {
                    Id = 7,
                    Name = "Bob Marley",
                    DateOfBirth = new DateTime(1945, 2, 6),
                    Phone = "+180321956489",
                    Email = "Marley@gmail.com",
                    InstagramUrl = "@BMarley"
                },
                new Artist
                {
                    Id = 8,
                    Name = "Basta",
                    DateOfBirth = new DateTime(1980, 4, 20),
                    Phone = "+780559523358",
                    Email = "Basta@gmail.com",
                    InstagramUrl = "@bastaakanoggano"
                },
                new Artist
                {
                    Id = 9,
                    Name = "Alyans",
                    DateOfBirth = new DateTime(1980, 4, 20),
                    Phone = "+780559525148",
                    Email = "Alyans@gmail.com",
                    InstagramUrl = "@alliancebandmoscow"
                });
        }
    }
}
