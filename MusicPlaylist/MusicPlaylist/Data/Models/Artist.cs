using System.ComponentModel.DataAnnotations;

namespace MusicPlaylist.Data.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
