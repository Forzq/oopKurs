namespace oop2.DTO
{
    public record ClientDto(int Id, string Name, string PhoneNumber);
    public record EquipmentDto(int Id, string Description , string Name, int OrderId);
    public record EquipmentServiceDto(int EquipmentId, int ServiceId, int count );
    public record MasterDto(int Id, string Name, string contactInfo, string specialization);
    public record OrderDto(int Id, int ClientId, int MasterId, string Status);
    public record ServiceDto(int Id, string Name, int Price);
}
