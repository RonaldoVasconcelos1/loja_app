using System.Threading.Tasks;
using Loja.Business.Contracts;
using Loja.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Loja.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> Post(Client model)
        {
            return Ok(await _service.Post(model));
        }

        // [HttpPut]
        // [Route("{id:int}")]
        // public async Task<Client> Put(Client model, int id)
        // {
        //     return await _service.Update(model, id);
        // }

        // [HttpDelete]
        // [Route("{id:int}")]
        // public async Task<bool> Delete(int id)
        // {
        //     return await _service.Delete(id);
        // }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<Client[]>> GetAll()
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

            // }

            // [HttpGet]
            // [Route("{cpf:string}")]
            // public async Task<ActionResult<Client>> GetByCpf(string cpf)
            // {
            //     try
            //     {
            //         return Ok(await _service.GetByCpf(cpf));
            //     }
            //     catch (System.Exception ex)
            //     {
            //         return BadRequest(ex.Message);
            //     }
            // }

            // [HttpGet]
            // [Route("{id:int}")]
            // public async Task<Client> GetById(int id)
            // {
            //     return await _service.GetById(id);
            // }

        }
    }
}