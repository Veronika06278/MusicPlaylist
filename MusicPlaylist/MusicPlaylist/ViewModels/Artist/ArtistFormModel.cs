using System.ComponentModel.DataAnnotations;
using static MusicPlaylist.Constants.Constants.ArtistConstants;

namespace MusicPlaylist.ViewModels.Artist
{
    public class ArtistFormModel
    {
        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DescriptionMaxLenght)]
        public string? Description { get; set; }
    }
}
