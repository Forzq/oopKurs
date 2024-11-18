using System.ComponentModel.DataAnnotations.Schema;

namespace oop2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        
        public int ClientsId { get; set; }
        public int ServicesId { get; set; }
        public Services Services { get; set; } = null!;
        public Clients Clients { get; set; } = null!;
        public Masters Masters { get; set; } = null!;
        public int MasterId { get; set; }
        public int TypeOfEquipmentId { get; set; }
        public TypeOfEquipment TypeOfEquipment { get; set; } = null!; 
    }
}
