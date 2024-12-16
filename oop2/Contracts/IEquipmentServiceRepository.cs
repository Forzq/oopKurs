using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IEquipmentServiceRepository
    {
        IEnumerable<EquipmentServiceDto> GetAllEquipmentServices(bool trackChanges);
        EquipmentServiceDto GetEquipmentServiceById(int EquipmentId, bool trackChanges);
    }
}
