namespace oop2.Models
{
    public class Clients
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int PhoneNumber{ get; set; }
        public ICollection<Orders> Orders { get;} = new List<Orders>();
    }
}
