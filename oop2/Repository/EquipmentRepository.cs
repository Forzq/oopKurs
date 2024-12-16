using oop2.Contracts;
using oop2.Models;

namespace oop2.Repository
{
    public class EquipmentRepository : RepositoryBase<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(RepositoryContext context)
        : base(context) { }

        public IEnumerable<Equipment> GetAllEquipments(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
        }
        public Equipment GetEquipment(int id, bool trackChanges)
        {
            return FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
