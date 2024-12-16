using oop2.Models;

namespace oop2.Contracts
{
    public interface IServiceRepository
    {
        IEnumerable<Service> GetAllServices(bool trackChanges);
        Service GetService(int id, bool trackChanges);
    }
}
