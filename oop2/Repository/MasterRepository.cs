using oop2.Contracts;
using oop2.Models;

namespace oop2.Repository
{
    public class MasterRepository : RepositoryBase<Master>, IMasterRepository
    {
        public MasterRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<Master> GetAllMasters(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
        }
        public Master GetMaster(int id, bool trackChanges)
        {
            return FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
