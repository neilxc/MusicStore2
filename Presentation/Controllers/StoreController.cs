using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [HttpGet("[action]")]   
        public string GetGenres()
        {
            return "This will be a list of genres";
        }

        [HttpGet("[action]")] 
        public string GetAlbums(string genre)
        {
            return "List of albums, Genre = " + genre;
        }

        [HttpGet("[action]/{id}")] 
        public IActionResult Details(int id)
        {
            var album = new Album {Title = "Album " + id};
            return Ok(album);
        }
    }    
}