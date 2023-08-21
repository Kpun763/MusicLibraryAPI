using MusicLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicLibraryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MusicLibrary> MusicLibraries { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }


    }
}
