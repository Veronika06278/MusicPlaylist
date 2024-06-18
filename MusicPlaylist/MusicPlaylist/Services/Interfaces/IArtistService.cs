using MusicPlaylist.Data.Models;
using MusicPlaylist.ViewModels.Artist;

namespace MusicPlaylist.Services.Interfaces
{
    public interface IArtistService
    {
        public IEnumerable<ArtistViewModel> GetArtists();

        public Task<bool> AddAsync(ArtistFormModel model);
        public ArtistDetailsModel? GetArtistDetails(int id);
        IEnumerable<ArtistDropDownModel> GetArtistsDropDown();
        
    }
}
