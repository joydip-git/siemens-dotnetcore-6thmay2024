using BusinessLogic;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PmsAppExceptions;

namespace PmsAppRestFulService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IServiceContract<Product, int> service) : ControllerBase
    {
        private readonly IServiceContract<Product, int> _service = service;

        [HttpGet("all")]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            try
            {
                //return _service.FetchAll() ?? [];
                return Ok(_service.FetchAll());
            }
            catch (ServiceException)
            {
                //throw ex;
                return this.BadRequest("error occurred..try later");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetSingle([FromRoute] int id)
        {
            try
            {
                //return _service.FetchAll() ?? [];
                return Ok(_service.Fetch(id));
            }
            catch (ServiceException)
            {
                //throw ex;
                return this.BadRequest("error occurred..try later");
            }

        }

        [HttpPost("add")]
        public ActionResult<Product> Add([FromBody] Product product)
        {
            try
            {
                Console.WriteLine(product);
                //return _service.FetchAll() ?? [];
                var res = _service.Insert(product);
                return Created("Add", res ? product : "not added");
            }
            catch (ServiceException ex)
            {
                Console.WriteLine(ex.InnerException);
                //throw ex;
                return this.BadRequest("error occurred..try later");
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<Product> Delete([FromRoute] int id)
        {
            return null;
        }

        [HttpPost("update/{id}")]
        public ActionResult<Product> Update([FromRoute] int id, [FromBody] Product product)
        {
            return null;
        }
    }
}
