using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class EquipmentServiceRepository : RepositoryBase<EquipmentService>, IEquipmentServiceRepository
    {
        public EquipmentServiceRepository(RepositoryContext context)
            : base(context) { }

        private readonly IMapper _mapper;
        public EquipmentServiceRepository(RepositoryContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }
        public IEnumerable<EquipmentServiceDto> GetAllEquipmentServices(bool trackChanges)
        {
            var equipmentservices = FindAll(trackChanges)
                .OrderBy(g => g.EquipmentId)
                .ToList();
            //var equipmentservicesDto = equipmentservices.Select(c =>
            //new EquipmentServiceDto(c.count, c.EquipmentId, c.ServiceId)
            //).ToList();
            if (equipmentservices is null)
            {
                throw new Exception("can not be null");
            }
            var equipmentservicesDto = _mapper.Map<IEnumerable<EquipmentServiceDto>>(equipmentservices);
            return equipmentservicesDto;
        }
        public EquipmentServiceDto GetEquipmentServiceById(int EquipmentId, bool trackChanges)
        {

            var equipmentservice = FindByCondition(g => g.EquipmentId.Equals(EquipmentId), trackChanges)
                .SingleOrDefault();
            if (equipmentservice is null)
            {
                throw new Exception("id can not be null");
            }
            var equipmentserviceDto = _mapper.Map<EquipmentServiceDto>(equipmentservice);
            //var equipmentserviceDto = new EquipmentServiceDto(equipmentservice.ServiceId, equipmentservice.EquipmentId, equipmentservice.count);
            return equipmentserviceDto;
        }
    }
}
