using oop2.Models;

namespace oop2.Contracts
{
    public interface IEquipmentServiceRepository
    {
        IEnumerable<EquipmentService> GetAllEquipmentServices(bool trackChanges);
        //EquipmentService GetServiceById(int id, bool trackChanges);
    }
}
