using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(RepositoryContext context)
            : base(context) { }

        public IEnumerable<ServiceDto> GetAllServices(bool trackChanges)
        {
            var services = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            var servicesDto = services.Select(c =>
            new ServiceDto(c.Id, c.Name, c.Price)
            ).ToList();
            return servicesDto;
        }
        public ServiceDto GetService(int id, bool trackChanges)
        {

            var service = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            var serviceDto = new ServiceDto(service.Id, service.Name, service.Price);
            return serviceDto;
        }
    }
}
