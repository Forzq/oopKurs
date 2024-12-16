using Microsoft.AspNetCore.Components.Web;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients(bool trackChanges);
        Client GetClient(int id, bool trackChanges);
    }
}
