namespace oop2.Models
{
    public class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string contactInfo { get; set; }
        public string specialization {  get; set; }
        public ICollection<Order> Order { get; } = new List<Order>(); 
    }
}
