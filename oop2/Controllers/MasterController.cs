using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;
using oop2.Repository;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/masters")]
    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository _masterRepository;
        public MasterController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        
        [HttpGet]
        public IActionResult GetAllMasters()
        {
            var masters = _masterRepository.GetAllMasters(trackChanges: false);
            return Ok(masters);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetMaster(int id)
        {
            var master = _masterRepository.GetMaster(id, trackChanges: false);
            return Ok(master);
        }
    }
}

