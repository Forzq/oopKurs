using Microsoft.AspNetCore.Components.Web;
using oop2.DTO;
using oop2.Models;

namespace oop2.Contracts
{
    public interface IClientRepository
    {
        IEnumerable<ClientDto> GetAllClients(bool trackChanges);
        ClientDto GetClient(int id, bool trackChanges);
    }
}
