using oop2.Contracts;
using oop2.Models;

namespace oop2.Repository
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<Service> GetAllServices(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
        }
        public Service GetService(int id, bool trackChanges)
        {
            return FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
