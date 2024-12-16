using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class EquipmentRepository : RepositoryBase<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(RepositoryContext context)
        : base(context) { }

        public IEnumerable<EquipmentDto> GetAllEquipments(bool trackChanges)
        {
            var equipments = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            var equipmentsDto = equipments.Select(c =>
            new EquipmentDto(c.Id, c.Description, c.Name, c.OrderId)
            ).ToList();
            return equipmentsDto;
        }
        public EquipmentDto GetEquipment(int id, bool trackChanges)
        {

            var equipment = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            var equipmentDto = new EquipmentDto(equipment.Id, equipment.Description, equipment.Name, equipment.OrderId);
            return equipmentDto;
        }
    }
}
