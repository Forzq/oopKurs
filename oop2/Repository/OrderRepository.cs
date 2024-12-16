using oop2.Contracts;
using oop2.Models;

namespace oop2.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<Order> GetAllOrders(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
        }
        public Order GetOrder(int id, bool trackChanges)
        {
            return FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
    }
}
