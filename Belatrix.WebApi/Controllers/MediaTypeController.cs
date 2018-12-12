using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/mediaType")]
    [ApiController]
    public class MediaTypeController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public MediaTypeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.MediaType.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.MediaType.GetList());
        }

        [HttpPost]
        public int Add(MediaType MediaType)
        {
            return _unit.MediaType.Add(MediaType);
        }

        [HttpPut]
        public int Update(MediaType MediaType)
        {
            return _unit.MediaType.Update(MediaType);
        }

        [HttpDelete]
        public int Delete(MediaType MediaType)
        {
            return _unit.MediaType.Delete(MediaType);
        }
    }
}