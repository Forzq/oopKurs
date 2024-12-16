using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext context)
        : base(context) { }

        public IEnumerable<ClientDto> GetAllClients(bool trackChanges)
        {
            var clients = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            var clientsDto = clients.Select(c =>
            new ClientDto(c.Id, c.Name, c.PhoneNumber)
            ).ToList();
            return clientsDto;
        }
        public ClientDto GetClient(int id, bool trackChanges)
        {

            var client = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            var clientDto = new ClientDto(client.Id, client.Name, client.PhoneNumber);
            return clientDto;
        }
    }
}
