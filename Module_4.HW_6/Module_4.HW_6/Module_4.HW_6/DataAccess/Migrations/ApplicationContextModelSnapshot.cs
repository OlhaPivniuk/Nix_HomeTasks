using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Module_4.HW_6.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module4HW6.Artist", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("DateOfBirth")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("InstagramUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Artist");

                b.HasData(
                    new
                    {
                        Id = 1,
                        DateOfBirth = new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Beatles@gmail.com",
                        InstagramUrl = "@thebeatles",
                        Name = "The Beatles",
                        Phone = "+180115438829"
                    },
                    new
                    {
                        Id = 2,
                        DateOfBirth = new DateTime(1958, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Madonna@gmail.com",
                        InstagramUrl = "@madonna",
                        Name = "Madonna",
                        Phone = "+180115438816"
                    },
                    new
                    {
                        Id = 3,
                        DateOfBirth = new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "eminem@gmail.com",
                        InstagramUrl = "@eminem",
                        Name = "Eminem",
                        Phone = "+180253246628"
                    },
                    new
                    {
                        Id = 4,
                        DateOfBirth = new DateTime(1925, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "BBKing@gmail.com",
                        InstagramUrl = "@B.B.King",
                        Name = "B.B.King",
                        Phone = "+120863544495"
                    },
                    new
                    {
                        Id = 5,
                        DateOfBirth = new DateTime(1962, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Krug@gmail.com",
                        InstagramUrl = "@MKrug",
                        Name = "Mihail Krug",
                        Phone = "+780779379992"
                    },
                    new
                    {
                        Id = 6,
                        DateOfBirth = new DateTime(1989, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "avicii@gmail.com",
                        InstagramUrl = "@avicii",
                        Name = "Avicii",
                        Phone = "+180662354489"
                    },
                    new
                    {
                        Id = 7,
                        DateOfBirth = new DateTime(1945, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Marley@gmail.com",
                        InstagramUrl = "@BMarley",
                        Name = "Bob Marley",
                        Phone = "+180321956489"
                    },
                    new
                    {
                        Id = 8,
                        DateOfBirth = new DateTime(1980, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Basta@gmail.com",
                        InstagramUrl = "@bastaakanoggano",
                        Name = "Basta",
                        Phone = "+780559523358"
                    },
                    new
                    {
                        Id = 9,
                        DateOfBirth = new DateTime(1980, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Email = "Alyans@gmail.com",
                        InstagramUrl = "@alliancebandmoscow",
                        Name = "Alyans",
                        Phone = "+780559525148"
                    });
            });

            modelBuilder.Entity("Module_4.HW_6.Genre", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Title")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.ToTable("Genre");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Title = "Rock"
                    },
                    new
                    {
                        Id = 2,
                        Title = "Pop"
                    },
                    new
                    {
                        Id = 3,
                        Title = "Rap"
                    },
                    new
                    {
                        Id = 4,
                        Title = "Blues"
                    },
                    new
                    {
                        Id = 5,
                        Title = "Shanson"
                    },
                    new
                    {
                        Id = 6,
                        Title = "Electronic"
                    },
                    new
                    {
                        Id = 7,
                        Title = "Reggae"
                    });
            });

            modelBuilder.Entity("Module_4.HW_6.Song", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Duration")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)");

                b.Property<int>("GenreId")
                    .HasColumnType("int");

                b.Property<DateTime>("ReleaseDate")
                    .HasColumnType("date");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.HasIndex("GenreId");

                b.ToTable("Song");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Duration = "3:07",
                        GenreId = 1,
                        ReleaseDate = new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Something"
                    },
                    new
                    {
                        Id = 2,
                        Duration = "5:33",
                        GenreId = 2,
                        ReleaseDate = new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Hung Up"
                    },
                    new
                    {
                        Id = 3,
                        Duration = "5:29",
                        GenreId = 2,
                        ReleaseDate = new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Frozen"
                    },
                    new
                    {
                        Id = 4,
                        Duration = "5:23",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Lose Yourself"
                    },
                    new
                    {
                        Id = 5,
                        Duration = "4:17",
                        GenreId = 3,
                        ReleaseDate = new DateTime(2004, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Mockingbird"
                    },
                    new
                    {
                        Id = 6,
                        Duration = "4:27",
                        GenreId = 5,
                        ReleaseDate = new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Vladimir Central"
                    },
                    new
                    {
                        Id = 7,
                        Duration = "11:05",
                        GenreId = 4,
                        ReleaseDate = new DateTime(1993, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "The Thrill Is Gone"
                    },
                    new
                    {
                        Id = 8,
                        Duration = "4:32",
                        GenreId = 6,
                        ReleaseDate = new DateTime(2013, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Wake Me Up"
                    },
                    new
                    {
                        Id = 9,
                        Duration = "7:10",
                        GenreId = 7,
                        ReleaseDate = new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "No Woman, No Cry"
                    },
                    new
                    {
                        Id = 10,
                        Duration = "5:56",
                        GenreId = 1,
                        ReleaseDate = new DateTime(1987, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        Title = "Na Zare"
                    });
            });

            modelBuilder.Entity("Module_4.HW_6.SongArtist", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("ArtistId")
                    .HasColumnType("int");

                b.Property<int?>("SongId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ArtistId");

                b.HasIndex("SongId");

                b.ToTable("SongArtist");

                b.HasData(
                    new
                    {
                        Id = 1,
                        ArtistId = 1,
                        SongId = 1
                    },
                    new
                    {
                        Id = 2,
                        ArtistId = 2,
                        SongId = 2
                    },
                    new
                    {
                        Id = 3,
                        ArtistId = 2,
                        SongId = 3
                    },
                    new
                    {
                        Id = 4,
                        ArtistId = 3,
                        SongId = 4
                    },
                    new
                    {
                        Id = 5,
                        ArtistId = 3,
                        SongId = 5
                    },
                    new
                    {
                        Id = 6,
                        ArtistId = 4,
                        SongId = 7
                    },
                    new
                    {
                        Id = 7,
                        ArtistId = 5,
                        SongId = 6
                    },
                    new
                    {
                        Id = 8,
                        ArtistId = 6,
                        SongId = 8
                    },
                    new
                    {
                        Id = 9,
                        ArtistId = 7,
                        SongId = 9
                    },
                    new
                    {
                        Id = 10,
                        ArtistId = 8,
                        SongId = 10
                    },
                    new
                    {
                        Id = 11,
                        ArtistId = 9,
                        SongId = 10
                    });
            });

            modelBuilder.Entity("Module_4.HW_6.Song", b =>
            {
                b.HasOne("Module_4.HW_6.Genre", "Genre")
                    .WithMany("Songs")
                    .HasForeignKey("GenreId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Genre");
            });

            modelBuilder.Entity("Module_4.HW_6.SongArtist", b =>
            {
                b.HasOne("Module_4.HW_6.Artist", "Artist")
                    .WithMany("SongArtists")
                    .HasForeignKey("ArtistId");

                b.HasOne("Module_4.HW_6.Song", "Song")
                    .WithMany("SongArtist")
                    .HasForeignKey("SongId");

                b.Navigation("Artist");

                b.Navigation("Song");
            });

            modelBuilder.Entity("Module_4.HW_6.Artist", b =>
            {
                b.Navigation("SongArtists");
            });

            modelBuilder.Entity("Module_4.HW_6.Genre", b =>
            {
                b.Navigation("Songs");
            });

            modelBuilder.Entity("Module_4.HW_6.Song", b =>
            {
                b.Navigation("SongArtist");
            });
#pragma warning restore 612, 618
        }
    }
}
