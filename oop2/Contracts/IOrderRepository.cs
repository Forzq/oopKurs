using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<OrderDto> GetAllOrders(bool trackChanges);
        OrderDto GetOrder(int id, bool trackChanges);
    }
}
