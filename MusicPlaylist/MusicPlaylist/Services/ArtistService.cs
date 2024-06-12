using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Data.Models;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Artist;

namespace MusicPlaylist.Services
{
    public class ArtistService : IArtistService
    {
        private readonly MusicPlaylistDbContext _dbcontext;

        public ArtistService(MusicPlaylistDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        
        public async Task<bool> AddAsync(ArtistFormModel model)
        {
            Artist artist = new Artist
            {
                Name = model.Name,
                Description = model.Description
            };

            await _dbcontext.AddAsync(artist);
            int savedChangedEntitiesCount = await _dbcontext.SaveChangesAsync();

            if (savedChangedEntitiesCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
