using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public InvoiceController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Invoice.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.Invoice.GetList());
        }

        [HttpPost]
        public int Add(Invoice Invoice)
        {
            return _unit.Invoice.Add(Invoice);
        }

        [HttpPut]
        public int Update(Invoice Invoice)
        {
            return _unit.Invoice.Update(Invoice);
        }

        [HttpDelete]
        public int Delete(Invoice Invoice)
        {
            return _unit.Invoice.Delete(Invoice);
        }
    }
}