using oop2.Models;

namespace oop2.Contracts
{
    public interface IMasterRepository
    {
        IEnumerable<Master> GetAllMasters(bool trackChanges);
        Master GetMaster(int id, bool trackChanges);
    }
}
