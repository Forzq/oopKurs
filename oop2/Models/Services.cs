namespace oop2.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<EquipmentServices> EquipmentServices { get;} = new List<EquipmentServices>();
    }
}
