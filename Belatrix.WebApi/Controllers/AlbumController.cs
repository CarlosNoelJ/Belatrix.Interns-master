using Microsoft.AspNetCore.Mvc;
using Belatrix.Models;
using Belatrix.Repository;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/album")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public AlbumController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Album.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Album.GetList());
        }

        [HttpPost]
        public int Add(Album Album)
        {
            return _unit.Album.Add(Album);
        }

        [HttpPut]
        public int Update(Album Album)
        {
            return _unit.Album.Update(Album);
        }

        [HttpDelete]
        public int Delete(Album Album)
        {
            return _unit.Album.Delete(Album);
        }
    }
}