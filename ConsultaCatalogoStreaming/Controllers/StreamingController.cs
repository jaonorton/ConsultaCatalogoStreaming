using ConsultaCatalogoStreaming.Models;
using ConsultaCatalogoStreaming.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConsultaCatalogoStreaming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamingController : ControllerBase
    {
        private MovieServices _movieService = new MovieServices();

        [HttpGet]
        public async Task<ActionResult> GetServiceStreaming([FromQuery(Name = "q")]string movieName)
        {
            MovieResponse movie = await _movieService.SerchForAMovieAsync(movieName);

            return Ok(movie);
        }
    }
}
