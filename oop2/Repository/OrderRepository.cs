using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<OrderDto> GetAllOrders(bool trackChanges)
        {
            var orders = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            var ordersDto = orders.Select(c =>
            new OrderDto(c.Id, c.ClientId, c.MasterId, c.Status)
            ).ToList();
            return ordersDto;
        }
        public OrderDto GetOrder(int id, bool trackChanges)
        {

            var order = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            var orderDto = new OrderDto(order.Id, order.ClientId, order.MasterId, order.Status);
            return orderDto;
        }
    }
}
