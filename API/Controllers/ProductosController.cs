using API.Entitys;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductosController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> FindAll()
        {
            return Ok(await _repository.FindAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Productos?>> GetById(int id)
        {
            var producto = await _repository.GetById(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }
    }
}
