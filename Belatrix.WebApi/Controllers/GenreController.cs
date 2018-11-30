using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/genre")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public GenreController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_unit.Genres.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Genres.GetList());
        }

        [HttpPost]
        public int Add(Genre genre)
        {
            return _unit.Genres.Add(genre);
        }

        [HttpPut]
        public bool Update(Genre genre)
        {
            return _unit.Genres.Update(genre);
        }

        [HttpDelete]
        public bool Delete(Genre genre)
        {
            return _unit.Genres.Delete(genre);
        }
    }
}