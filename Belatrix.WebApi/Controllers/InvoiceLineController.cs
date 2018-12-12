using Belatrix.Models;
using Belatrix.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Belatrix.WebApi.Controllers
{
    [Route("api/invoiceLine")]
    [ApiController]
    public class InvoiceLineController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public InvoiceLineController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.InvoiceLine.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unit.InvoiceLine.GetList());
        }

        [HttpPost]
        public int Add(InvoiceLine InvoiceLine)
        {
            return _unit.InvoiceLine.Add(InvoiceLine);
        }

        [HttpPut]
        public int Update(InvoiceLine InvoiceLine)
        {
            return _unit.InvoiceLine.Update(InvoiceLine);
        }

        [HttpDelete]
        public int Delete(InvoiceLine InvoiceLine)
        {
            return _unit.InvoiceLine.Delete(InvoiceLine);
        }
    }
}