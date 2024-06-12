using MusicPlaylist.Data.Models;
using MusicPlaylist.ViewModels.Artist;

namespace MusicPlaylist.Services.Interfaces
{
    public interface IArtistService
    {
        

        public Task<bool> AddAsync(ArtistFormModel model);
    }
}
