using AutoMapper;
using oop2.DTO;
using oop2.Models;

namespace oop2.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        CreateMap<Client, ClientDto>();
            CreateMap<Equipment, EquipmentDto>();
            CreateMap<EquipmentService, EquipmentServiceDto>();
            CreateMap<Master, MasterDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Service, ServiceDto>();
        }
    }
}
