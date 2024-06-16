using MusicPlaylist.Data;
using MusicPlaylist.Data.Models;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Artist;
using MusicPlaylist.ViewModels.Song;

namespace MusicPlaylist.Services
{
    public class SongService : ISongService
    {
        private readonly MusicPlaylistDbContext _dbcontext;

        public SongService(MusicPlaylistDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<bool> AddSongAsync(SongFormModel model)
        {
            Song song=new Song
            {
                Title= model.Title,
                ImageUrl= model.ImageUrl,
                ArtistId= model.ArtistId,
            };
            await _dbcontext.AddAsync(song);
            int savedChangedEntitiesCount = await _dbcontext.SaveChangesAsync();
            if (savedChangedEntitiesCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
