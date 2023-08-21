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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicLibrary>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicLibrary>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicLibrary>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
