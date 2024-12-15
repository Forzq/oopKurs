namespace oop2.Models
{
    public class EquipmentService
    {
        public int count {  get; set; }
        public int EquipmentId { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
        public Equipment Equipment { get; set; } = null!;
    }
}
