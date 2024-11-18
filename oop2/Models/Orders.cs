using System.ComponentModel.DataAnnotations.Schema;

namespace oop2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        
        public int ClientsId { get; set; }
        public Clients Clients { get; set; } = null!;
        public int ServicesId { get; set; }
        public Services Services { get; set; } = null!;
        public int MasterId { get; set; }
        public Masters Masters { get; set; } = null!;
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;
    }
}
