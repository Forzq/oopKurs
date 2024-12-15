using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData
               (
                   new Order
                   {
                       Id = 1,
                       ClientId =1,
                       ServiceId = 1,
                       MasterId = 1,
                       Status = "Выполнен"
                   },
                   new Order
                   {
                       Id = 2,
                       ClientId = 2,
                       ServiceId = 1,
                       MasterId = 2,
                       Status = "Выполнен"
                   },
                    new Order
                    {
                        Id = 3,
                        ClientId = 3,
                        ServiceId = 1,
                        MasterId = 3,
                        Status = "В процессе"
                    },
                    new Order
                    {
                        Id = 4,
                        ClientId = 4,
                        ServiceId = 1,
                        MasterId = 4,
                        Status = "Отменен"
                    },
                    new Order
                    {
                        Id = 5,
                        ClientId = 5,
                        ServiceId = 1,
                        MasterId = 5,
                        Status = "Выполнен"
                    }



               );
        }
    }
}
