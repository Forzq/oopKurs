using AutoMapper;
using oop2.Contracts;
using oop2.DTO;
using oop2.Models;

namespace oop2.Repository
{
    public class MasterRepository : RepositoryBase<Master>, IMasterRepository
    {
        public MasterRepository(RepositoryContext context)
            : base(context) { }
        private readonly IMapper _mapper;
        public MasterRepository(RepositoryContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }
        public IEnumerable<MasterDto> GetAllMasters(bool trackChanges)
        {
            var masters = FindAll(trackChanges)
                .OrderBy(g => g.Id)
                .ToList();
            //var mastersDto = masters.Select(c =>
            //new MasterDto(c.Id, c.Name, c.contactInfo, c.specialization)
            //).ToList();
            if (masters is null)
            {
                throw new Exception("can not be null");
            }
            var mastersDto = _mapper.Map<IEnumerable<MasterDto>>(masters);
            return mastersDto;
        }
        public MasterDto GetMaster(int id, bool trackChanges)
        {

            var master = FindByCondition(g => g.Id.Equals(id), trackChanges)
                .SingleOrDefault();
            if (master is null)
            {
                throw new Exception("id can not be null");
            }
            var masterDto = _mapper.Map<MasterDto>(master);
            //var masterDto = new MasterDto(master.Id, master.Name, master.contactInfo, master.specialization);
            return masterDto;
        }
    }
}
