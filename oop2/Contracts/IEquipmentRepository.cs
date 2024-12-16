using oop2.Models;

namespace oop2.Contracts
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetAllEquipments(bool trackChanges);
        Equipment GetEquipment(int id, bool trackChanges);
    }
}
