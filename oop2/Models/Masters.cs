namespace oop2.Models
{
    public class Masters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string contactInfo { get; set; }
        public string specialization {  get; set; }
        public ICollection<Orders> Orders { get; } = new List<Orders>(); 
    }
}
