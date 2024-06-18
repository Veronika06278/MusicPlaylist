using MusicPlaylist.ViewModels.Artist;

namespace MusicPlaylist.ViewModels.Song
{
    public class SongViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        

        public string? ImageUrl { get; set; } 
        
    }
}
