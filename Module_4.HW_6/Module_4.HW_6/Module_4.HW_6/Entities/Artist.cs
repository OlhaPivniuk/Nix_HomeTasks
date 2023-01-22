namespace Module_4.HW_6.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<SongArtist> SongArtists { get; set; } = new List<SongArtist>();
    }
}
