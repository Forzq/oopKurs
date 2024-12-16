using oop2.Models;

namespace oop2.Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders(bool trackChanges);
        Order GetOrder(int id, bool trackChanges);
    }
}
