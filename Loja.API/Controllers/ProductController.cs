using System;
using System.Threading.Tasks;
using Loja.Business.Contracts;
using Loja.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product model)
        {
            return Ok(await _service.Post(model));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<Product> Put(Product model, int id)
        {
            return await _service.Update(model, id);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<Product[]>> GetAll()
        {
            try
            {
                var result = await _service.GetAll();

                if (result == null)
                    return BadRequest(result);

                return Ok(result);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet]
        [Route("{id:int}")]
        public async Task<Product> GetById(int id)
        {
            return await _service.GetById(id);
        }

    }
}
