using MusicPlaylist.ViewModels.Song;

namespace MusicPlaylist.ViewModels.Artist
{
    public class ArtistDetailsModel
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;
        public IEnumerable<SongViewModel> Songs { get; set; } = new List<SongViewModel>();
    }
}
