using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;
using oop2.Repository;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/services")]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        
        [HttpGet]
        public IActionResult GetAllServices()
        {
            var services = _serviceRepository.GetAllServices(trackChanges: false);
            return Ok(services);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetService(int id)
        {
            var service = _serviceRepository.GetService(id, trackChanges: false);
            return Ok(service);
        }
    }

}

