using MusicLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicLibraryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public MusicLibraryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<MusicLibrary>
        [HttpGet]
        public IActionResult Get()
        {
          var musiclibrary = _context.MusicLibraries.ToList();
            return Ok(musiclibrary);
        }

        // GET api/<MusicLibrary>/5
        [HttpGet("{id}")]
        public IActionResult GetSongById(int id)
        {
            var song = _context.MusicLibraries.Find(id);

            if (song == null) 
            return NotFound();

            return Ok(song);
        }

        // POST api/<MusicLibrary>
        [HttpPost]
        public IActionResult CreateSong([FromBody] MusicLibrary newSong)
        {
            if(newSong == null) return BadRequest();
            _context.MusicLibraries.Add(newSong);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSongById), new {id = newSong.Id}, newSong);
        }

        // PUT api/<MusicLibrary>/5
        [HttpPut("{id}")]
        public IActionResult UpdateSong(int id, [FromBody] MusicLibrary updatedSong)
        {
            var existingSong = _context.MusicLibraries.Find(id);
            if (existingSong == null)
                return NotFound();

            existingSong.Title = updatedSong.Title;
            existingSong.Artist = updatedSong.Artist;
            existingSong.Album = updatedSong.Album;
            existingSong.ReleaseDate = updatedSong.ReleaseDate;
            existingSong.Genre = updatedSong.Genre;
            _context.SaveChanges();
            return Ok(existingSong);
        }
        // PUT api/<MusicLibrary>/5
        [HttpPut("{id}/like")]
        public IActionResult LikeSong(int id)
        {
            var song = _context.MusicLibraries.Find(id);
            if (song == null) return NotFound();

            song.Likes++;
            _context.SaveChanges();

            return Ok(song.Likes);
        }

        // DELETE api/<MusicLibrary>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSong(int id)
        {
            var songToDelete = _context.MusicLibraries.Find(id);
            if (songToDelete == null) 
                return NotFound();

            _context.MusicLibraries.Remove(songToDelete);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
