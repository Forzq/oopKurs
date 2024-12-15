using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class EquipmentServiceConfiguration : IEntityTypeConfiguration<EquipmentService>
    {
        public void Configure(EntityTypeBuilder<EquipmentService> builder)
        {
            builder.HasKey(k => new { k.EquipmentId, k.ServiceId });

            builder.HasOne(es => es.Equipment)
                   .WithMany(e => e.EquipmentService)
                   .HasForeignKey(es => es.EquipmentId);

            builder.HasOne(es => es.Service)
                   .WithMany(s => s.EquipmentService)
                   .HasForeignKey(es => es.ServiceId);

            builder.HasData(
                new EquipmentService { count = 1, EquipmentId = 2, ServiceId = 1 },
                new EquipmentService { count = 2, EquipmentId = 3, ServiceId = 2 },
                new EquipmentService { count = 1, EquipmentId = 4, ServiceId = 1 },
                new EquipmentService { count = 3, EquipmentId = 5, ServiceId = 3 }
            );
        }
    }

}

