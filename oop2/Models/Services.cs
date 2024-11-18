namespace oop2.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<EquipmentServices> EquipmentServices { get; } = [];
        public List<Equipment> Equipment { get; } = [];
    }
}
