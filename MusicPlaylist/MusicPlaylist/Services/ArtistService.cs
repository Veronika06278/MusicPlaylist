using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data;
using MusicPlaylist.Data.Models;
using MusicPlaylist.Services.Interfaces;
using MusicPlaylist.ViewModels.Artist;
using MusicPlaylist.ViewModels.Song;

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
                Description = model.Description,
                ImageUrl=model.ImageUrl
            };

            await _dbcontext.AddAsync(artist);
            int savedChangedEntitiesCount = await _dbcontext.SaveChangesAsync();

            if (savedChangedEntitiesCount > 0)
            {
                return true;
            }
            return false;
        }

        public ArtistDetailsModel? GetArtistDetails(int id)
        {
            var result = _dbcontext.Artists
                .Where(a => a.Id == id)
                .Select(a => new ArtistDetailsModel
                {
                    Name = a.Name,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Songs = a.Songs.Select(s => new SongViewModel
                    {
                        Title = s.Title,
                    })
                    .ToList()
                })
                .FirstOrDefault();
            return result;
        }

        public IEnumerable<ArtistViewModel> GetArtists()
        {
            List<ArtistViewModel> result= _dbcontext.Artists
                .Select(x => new ArtistViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    ImageUrl=x.ImageUrl

                })
                .ToList();
            return result;
        }

        public IEnumerable<ArtistDropDownModel> GetArtistsDropDown()
        {
            List<ArtistDropDownModel> result = _dbcontext.Artists
               .Select(x => new ArtistDropDownModel
               {
                   Id = x.Id,
                   Name = x.Name,
               })
               .ToList();
            return result;
        }
    }
}
