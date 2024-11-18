namespace oop2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Orders> Orders { get;} = new List<Orders>();
        public List<EquipmentServices> EquipmentServices { get; } = [];
        public List<Services> Services { get; } = [];

        
    }
}
