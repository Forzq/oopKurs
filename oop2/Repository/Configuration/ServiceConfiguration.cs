using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasData
               (
                   new Service
                   {
                       Id = 1,
                       Name = "Читска оборудования",
                       Price = 10,
                   },
                       new Service
                   {
                       Id = 2,
                       Name = "Ремонт экрана",
                       Price = 25,
                   },
                    new Service
                    {
                        Id = 3,
                        Name = "Настройка сети",
                        Price = 15,
                    },
                    new Service
                    {
                        Id = 4,
                        Name = "Установка программного обеспечения",
                        Price = 20,
                    },
                    new Service
                    {
                        Id = 5,
                        Name = "Обслуживание принтера",
                        Price = 30,
                    }

               );
        }
    }
}
