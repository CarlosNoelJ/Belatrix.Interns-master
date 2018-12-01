using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/playlists")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public PlaylistController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Playlist.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Playlist.GetList());
        }

        [HttpPost]
        public int Add(Playlist playList)
        {
            return _unit.Playlist.Add(playList);
        }

        [HttpPut]
        public int Update(Playlist playlist)
        {
            return _unit.Playlist.Update(playlist);
        }

        [HttpDelete]
        public int Delete(Playlist playlist)
        {
            return _unit.Playlist.Delete(playlist);
        }
    }
}