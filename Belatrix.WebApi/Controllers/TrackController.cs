using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/track")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public TrackController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Track.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Track.GetList());
        }

        [HttpPost]
        public int Add(Track Track)
        {
            return _unit.Track.Add(Track);
        }

        [HttpPut]
        public int Update(Track Track)
        {
            return _unit.Track.Update(Track);
        }

        [HttpDelete]
        public int Delete(Track Track)
        {
            return _unit.Track.Delete(Track);
        }
    }
}