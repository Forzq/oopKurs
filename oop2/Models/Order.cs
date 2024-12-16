using System.ComponentModel.DataAnnotations.Schema;

namespace oop2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MasterId { get; set; }
        public string Status { get; set; }
        public Client Client { get; set; } = null!;
        public Master Master { get; set; } = null!;
        public ICollection<Equipment> Equipment { get; } = new List<Equipment>();
 
    }
}
