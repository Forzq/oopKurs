using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class EquipmentServiceRepository : RepositoryBase<EquipmentService>, IEquipmentServiceRepository
    {
        public EquipmentServiceRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<EquipmentServiceDto> GetAllEquipmentServices(bool trackChanges)
        {
            var equipmentservices = FindAll(trackChanges)
                .OrderBy(g => g.EquipmentId)
                .ToList();
            var equipmentservicesDto = equipmentservices.Select(c =>
            new EquipmentServiceDto(c.count, c.EquipmentId, c.ServiceId)
            ).ToList();
            return equipmentservicesDto;
        }
        public EquipmentServiceDto GetEquipmentServiceById(int EquipmentId, bool trackChanges)
        {

            var equipmentservice = FindByCondition(g => g.EquipmentId.Equals(EquipmentId), trackChanges)
                .SingleOrDefault();
            var equipmentserviceDto = new EquipmentServiceDto(equipmentservice.ServiceId, equipmentservice.EquipmentId, equipmentservice.count);
            return equipmentserviceDto;
        }
    }
}
