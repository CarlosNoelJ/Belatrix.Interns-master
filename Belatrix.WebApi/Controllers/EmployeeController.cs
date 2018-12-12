using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public EmployeeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Employee.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Employee.GetList());
        }

        [HttpPost]
        public int Add(Employee Employee)
        {
            return _unit.Employee.Add(Employee);
        }

        [HttpPut]
        public int Update(Employee Employee)
        {
            return _unit.Employee.Update(Employee);
        }

        [HttpDelete]
        public int Delete(Employee Employee)
        {
            return _unit.Employee.Delete(Employee);
        }
    }
}