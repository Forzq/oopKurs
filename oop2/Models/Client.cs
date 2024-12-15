namespace oop2.Models
{
    public class Client
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string PhoneNumber{ get; set; }
        public ICollection<Order> Order { get;} = new List<Order>();
    }
}
