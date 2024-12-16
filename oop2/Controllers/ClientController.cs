using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        [HttpGet]
        public IActionResult GetAllClients() 
        {
            var clients = _clientRepository.GetAllClients(trackChanges: false);
            return Ok(clients);
        }
    }
    

}
