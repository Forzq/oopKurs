using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class EquipmentRepository : RepositoryBase<Equipment>, IEquipmentRepository
    {
        public EquipmentRepository(RepositoryContext context)
        : base(context) { }

        private readonly IMapper _mapper;
        public EquipmentRepository(RepositoryContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }
        public IEnumerable<EquipmentDto> GetAllEquipments(bool trackChanges)
        {
            var equipments = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            //var equipmentsDto = equipments.Select(c =>
            //new EquipmentDto(c.Id, c.Description, c.Name, c.OrderId)
            //).ToList();
            if (equipments is null)
            {
                throw new Exception("can not be null");
            }
            var equipmentsDto = _mapper.Map<IEnumerable<EquipmentDto>>(equipments);
            return equipmentsDto;
        }
        public EquipmentDto GetEquipment(int id, bool trackChanges)
        {

            var equipment = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            if (equipment is null)
            {
                throw new Exception("id can not be null");
            }
            var equipmentDto = _mapper.Map<EquipmentDto>(equipment);
            //var equipmentDto = new EquipmentDto(equipment.Id, equipment.Description, equipment.Name, equipment.OrderId);
            return equipmentDto;
        }
    }
}
