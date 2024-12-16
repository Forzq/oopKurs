using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(RepositoryContext context)
            : base(context) { }

        private readonly IMapper _mapper;
        public ServiceRepository(RepositoryContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }
        public IEnumerable<ServiceDto> GetAllServices(bool trackChanges)
        {
            var services = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            //var servicesDto = services.Select(c =>
            //new ServiceDto(c.Id, c.Name, c.Price)
            //).ToList();
            if (services is null)
            {
                throw new Exception("can not be null");
            }
            var servicesDto = _mapper.Map<IEnumerable<ServiceDto>>(services);
            return servicesDto;
        }
        public ServiceDto GetService(int id, bool trackChanges)
        {

            var service = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            if (service is null)
            {
                throw new Exception("id can not be null");
            }
            var serviceDto = _mapper.Map<ServiceDto>(service);
            //var serviceDto = new ServiceDto(service.Id, service.Name, service.Price);
            return serviceDto;
        }
    }
}
