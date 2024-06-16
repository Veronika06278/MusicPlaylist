namespace MusicPlaylist.ViewModels.Artist
{
    public class ArtistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;

    }
}
