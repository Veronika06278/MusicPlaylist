using System.ComponentModel.DataAnnotations;
using static MusicPlaylist.Constants.Constants.SongConstants;
namespace MusicPlaylist.ViewModels.Song
{
    public class SongFormModel
    {
        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;
    }
}
