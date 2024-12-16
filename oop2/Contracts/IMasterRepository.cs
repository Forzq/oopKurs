using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IMasterRepository
    {
        IEnumerable<MasterDto> GetAllMasters(bool trackChanges);
        MasterDto GetMaster(int id, bool trackChanges);
    }
}
