using MusicLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MusicLibraryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MusicLibrary> MusicLibraries { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MusicLibrary>().HasData(
            new MusicLibrary { Id = 1, Title = "Chicago Freestyle", Artist = "Drake", Album = "Dark Lane Demo Tapes", ReleaseDate = new DateTime(2020,5,1), Genre = "Hip-Hop" },
            new MusicLibrary { Id = 2, Title = "Time Flies", Artist = "Drake", Album = "Dark Lane Demo Tapes", ReleaseDate = new DateTime(2020,5,1), Genre = "Hip-Hop" },
            new MusicLibrary { Id = 3, Title = "Madonna", Artist = "Drake", Album = "If You're Reading This It's Too Late", ReleaseDate = new DateTime(2015,2,13), Genre = "Hip-Hop" },
            new MusicLibrary { Id = 4, Title = "Adjustments", Artist = "Mad Keys", Album = "Adjustments - Single", ReleaseDate = new DateTime(2022,6,28), Genre = "Hip-Hop" }

            );
        }

    }
}
