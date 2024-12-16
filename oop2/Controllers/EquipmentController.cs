using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;
using oop2.Repository;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/equipments")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentRepository _equipmentRepository;
        public EquipmentController(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        [HttpGet]
        public IActionResult GetAllEquipments()
        {
            var equipments = _equipmentRepository.GetAllEquipments(trackChanges: false);
            return Ok(equipments);
        }
    }
}
