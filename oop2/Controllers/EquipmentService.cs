

using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;
using oop2.Repository;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/equipmentservices")]
    public class EquipmentServiceController : ControllerBase
    {
        private readonly IEquipmentServiceRepository _equipmentserviceRepository;
        public EquipmentServiceController(IEquipmentServiceRepository equipmentserviceRepository)
        {
            _equipmentserviceRepository = equipmentserviceRepository;
        }

        [HttpGet]
        public IActionResult GetAllEquipmentServices()
        {
            var equipmentservices = _equipmentserviceRepository.GetAllEquipmentServices(trackChanges: false);
            return Ok(equipmentservices);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetEquipmentService(int id)
        {
            var equipmentservice = _equipmentserviceRepository.GetEquipmentServiceById(id, trackChanges: false);
            return Ok(equipmentservice);
        }
    }


}
