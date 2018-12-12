using Microsoft.AspNetCore.Mvc;
using Belatrix.Models;
using Belatrix.Repository;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public CustomerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Customer.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Customer.GetList());
        }

        [HttpPost]
        public int Add(Customer Customer)
        {
            return _unit.Customer.Add(Customer);
        }

        [HttpPut]
        public int Update(Customer Customer)
        {
            return _unit.Customer.Update(Customer);
        }

        [HttpDelete]
        public int Delete(Customer Customer)
        {
            return _unit.Customer.Delete(Customer);
        }
    }
}