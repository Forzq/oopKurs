namespace oop2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int OrdersId { get; set; }
        public ICollection<EquipmentServices> EquipmentServices { get; } = new List<EquipmentServices>();
    }
}
