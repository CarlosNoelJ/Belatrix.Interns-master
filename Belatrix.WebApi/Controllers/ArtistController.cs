using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public ArtistController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Artists.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Artists.GetList());
        }

        [HttpPost]
        public IActionResult Add(Artist artists)
        {
            if (artists == null) return BadRequest();

            return Ok(_unit.Artists.Add(artists));
        }

        [HttpPut]
        public IActionResult Update(Artist artist)
        {
            //Artist art = _unit.Artists.GetById(artist.ArtistId);
            return Ok(_unit.Artists.Update(artist));
        }

        [HttpDelete]
        public IActionResult Delete(Artist artist)
        {
            return Ok(_unit.Artists.Delete(artist));
        }
    }
}