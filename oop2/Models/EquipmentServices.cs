namespace oop2.Models
{
    public class EquipmentServices
    {
        public int count {  get; set; }
        public int EquipmentId { get; set; }
        public int ServicesId { get; set; }
        public Services Services { get; set; } = null!;
        public Equipment Equipment { get; set; } = null!;
    }
}
