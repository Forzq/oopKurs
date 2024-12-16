using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IEquipmentRepository
    {
        IEnumerable<EquipmentDto> GetAllEquipments(bool trackChanges);
        EquipmentDto GetEquipment(int id, bool trackChanges);
    }
}
