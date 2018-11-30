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
        public int Add(Artist artists)
        {
            return _unit.Artists.Add(artists);
        }

        [HttpPut]
        public bool Update(Artist artist)
        {
            //Artist art = _unit.Artists.GetById(artist.ArtistId);
            return _unit.Artists.Update(artist);
        }

        [HttpDelete]
        public bool Delete(Artist artist)
        {
            return _unit.Artists.Delete(artist);
        }
    }
}