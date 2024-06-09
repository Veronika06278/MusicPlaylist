using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Data.Models;

namespace MusicPlaylist.Data
{
    public class MusicPlaylistDbContext : IdentityDbContext
    {
        public MusicPlaylistDbContext(DbContextOptions<MusicPlaylistDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
