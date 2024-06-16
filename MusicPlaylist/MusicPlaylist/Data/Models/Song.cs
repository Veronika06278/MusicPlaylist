using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static MusicPlaylist.Constants.Constants.SongConstants;

namespace MusicPlaylist.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;
        
        public string? ImageUrl { get; set; } 

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }
        [Required]
        public Artist Artist { get; set; } = null!;
    }
}
