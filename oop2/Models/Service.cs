namespace oop2.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<EquipmentService> EquipmentService { get; } = [];
    }
}
