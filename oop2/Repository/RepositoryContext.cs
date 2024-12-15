using Microsoft.EntityFrameworkCore;
using oop2.Models;
using oop2.Repository.Configuration;

namespace oop2.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options) { }
         
        public DbSet<Client> Client { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Master> Master { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<EquipmentService> EquipmentService { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new MasterConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentServiceConfiguration());
        }
    }
    
}
