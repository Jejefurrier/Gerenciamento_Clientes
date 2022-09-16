using Gerenciamento_Clientes.Business;
using Gerenciamento_Clientes.Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gerenciamento_Clientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteBusiness clienteBusiness;
        public ClientesController(IClienteBusiness _clienteBusiness)
        {
            clienteBusiness = _clienteBusiness;
        }

        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return clienteBusiness.Listar();
        }
        

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            clienteBusiness.Registrar(cliente);
        }

        // PUT api/<ClientesController>/5
        [HttpPut]
        public void Put([FromBody] Cliente cliente)
        {
            clienteBusiness.Editar(cliente);
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clienteBusiness.Excluir(id);
        }
    }
}
