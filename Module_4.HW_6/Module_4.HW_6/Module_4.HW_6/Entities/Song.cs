namespace Module_4.HW_6.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<SongArtist> SongArtist { get; set; } = new List<SongArtist>();
    }
}
