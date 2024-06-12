using MusicPlaylist.Data.Models;
using MusicPlaylist.ViewModels.Song;

namespace MusicPlaylist.Services.Interfaces
    
{
    public interface ISongService
    {
        public Task<bool> AddSongAsync(SongFormModel model)
    }
}
