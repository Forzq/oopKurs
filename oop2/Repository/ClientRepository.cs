using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext context)
        : base(context) { }

        private readonly IMapper _mapper;
        public ClientRepository(RepositoryContext context, IMapper mapper)
            : base(context) 
        {
            _mapper = mapper;    
        }
        public IEnumerable<ClientDto> GetAllClients(bool trackChanges)
        {
            var clients = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            //var clientsDto = clients.Select(c =>
            //new ClientDto(c.Id, c.Name, c.PhoneNumber)
            //).ToList();
            if (clients is null)
            {
                throw new Exception("can not be null");
            }
            var clientsDto = _mapper.Map<IEnumerable<ClientDto>>(clients);
            return clientsDto;
        }
        public ClientDto GetClient(int id, bool trackChanges)
        {
            var client = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            if (client is null)
            {
                throw new Exception("id can not be null");
            }
            var clientDto = _mapper.Map<ClientDto>(client);
            //var clientDto = new ClientDto(client.Id, client.Name, client.PhoneNumber);
            return clientDto;
        }
    }
}
