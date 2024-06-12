﻿using System.ComponentModel.DataAnnotations;
using static MusicPlaylist.Constants.Constants.ArtistConstants;

namespace MusicPlaylist.Data.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DescriptionMaxLenght)]
        public string? Description { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
