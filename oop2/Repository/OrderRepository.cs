using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext context)
            : base(context) { }

        private readonly IMapper _mapper;
        public OrderRepository(RepositoryContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }
        public IEnumerable<OrderDto> GetAllOrders(bool trackChanges)
        {
            var orders = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            //var ordersDto = orders.Select(c =>
            //new OrderDto(c.Id, c.ClientId, c.MasterId, c.Status)
            //).ToList();
            if (orders is null)
            {
                throw new Exception("can not be null");
            }
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return ordersDto;
        }
        public OrderDto GetOrder(int id, bool trackChanges)
        {

            var order = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            if (order is null)
            {
                throw new Exception("id can not be null");
            }
            var orderDto = _mapper.Map<OrderDto>(order);
            //var orderDto = new OrderDto(order.Id, order.ClientId, order.MasterId, order.Status);
            return orderDto;
        }
    }
}
