using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module_4.HW_6.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongArtist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(type: "int", nullable: true),
                    ArtistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongArtist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongArtist_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SongArtist_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatles@gmail.com", "@thebeatles", "The Beatles", "+180115438829" },
                    { 2, new DateTime(1958, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madonna@gmail.com", "@madonna", "Madonna", "+180115438816" },
                    { 3, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "eminem@gmail.com", "@eminem", "Eminem", "+180253246628" },
                    { 4, new DateTime(1925, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "BBKing@gmail.com", "@B.B.King", "B.B.King", "+120863544495" },
                    { 5, new DateTime(1962, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krug@gmail.com", "@MKrug", "Mihail Krug", "+780779379992" },
                    { 6, new DateTime(1989, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "avicii@gmail.com", "@avicii", "Avicii", "+180662354489" },
                    { 7, new DateTime(1945, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marley@gmail.com", "@BMarley", "Bob Marley", "+180321956489" },
                    { 8, new DateTime(1980, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basta@gmail.com", "@bastaakanoggano", "Basta", "+780559523358" },
                    { 9, new DateTime(1980, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alyans@gmail.com", "@alliancebandmoscow", "Alyans", "+780559525148" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop" },
                    { 3, "Rap" },
                    { 4, "Blues" },
                    { 5, "Shanson" },
                    { 6, "Electronic" },
                    { 7, "Reggae" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "Id", "Duration", "GenreId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3:07", 1, new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Something" },
                    { 10, "5:56", 1, new DateTime(1987, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Na Zare" },
                    { 2, "5:33", 2, new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hung Up" },
                    { 3, "5:29", 2, new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frozen" },
                    { 4, "5:23", 3, new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lose Yourself" },
                    { 5, "4:17", 3, new DateTime(2004, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mockingbird" },
                    { 7, "11:05", 4, new DateTime(1993, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Thrill Is Gone" },
                    { 6, "4:27", 5, new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladimir Central" },
                    { 8, "4:32", 6, new DateTime(2013, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wake Me Up" },
                    { 9, "7:10", 7, new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "No Woman, No Cry" }
                });

            migrationBuilder.InsertData(
                table: "SongArtist",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 10, 8, 10 },
                    { 11, 9, 10 },
                    { 2, 2, 2 },
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 3, 5 },
                    { 6, 4, 7 },
                    { 7, 5, 6 },
                    { 8, 6, 8 },
                    { 9, 7, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_GenreId",
                table: "Song",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SongArtist_ArtistId",
                table: "SongArtist",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_SongArtist_SongId",
                table: "SongArtist",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SongArtist");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
