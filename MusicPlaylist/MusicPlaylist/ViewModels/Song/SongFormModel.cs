using MusicPlaylist.ViewModels.Artist;
using System.ComponentModel.DataAnnotations;
using static MusicPlaylist.Constants.Constants.SongConstants;
namespace MusicPlaylist.ViewModels.Song
{
    public class SongFormModel
    {
        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public IEnumerable<ArtistDropDownModel> Artists { get; set; } = new List<ArtistDropDownModel>();

        public int ArtistId { get; set; }
    }
}
