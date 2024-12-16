using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IServiceRepository
    {
        IEnumerable<ServiceDto> GetAllServices(bool trackChanges);
        ServiceDto GetService(int id, bool trackChanges);
    }
}
