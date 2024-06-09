using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; } = null!;
    }
}
