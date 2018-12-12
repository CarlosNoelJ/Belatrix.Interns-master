using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/PlaylistTrack")]
    [ApiController]
    public class PlayListTrackController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public PlayListTrackController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.PlaylistTrack.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.PlaylistTrack.GetList());
        }

        [HttpPost]
        public int Add(PlaylistTrack PlaylistTrack)
        {
            return _unit.PlaylistTrack.Add(PlaylistTrack);
        }

        [HttpPut]
        public int Update(PlaylistTrack PlaylistTrack)
        {
            return _unit.PlaylistTrack.Update(PlaylistTrack);
        }

        [HttpDelete]
        public int Delete(PlaylistTrack PlaylistTrack)
        {
            return _unit.PlaylistTrack.Delete(PlaylistTrack);
        }
    }
}