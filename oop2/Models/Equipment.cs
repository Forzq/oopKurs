namespace oop2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public List<EquipmentService> EquipmentService { get; set; } = new List<EquipmentService>();
    }

}
