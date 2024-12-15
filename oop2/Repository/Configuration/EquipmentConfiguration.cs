using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.HasData
               (
                   new Equipment
                   {
                       Id = 1,
                       Description = "Screen broken",
                       Name = "LG l345",
                       OrderId = 1,
                       
                   },
                   new Equipment
                   {
                       Id = 2,
                       Description = "Projector malfunction",
                       Name = "Epson 123",
                       OrderId = 1,
                   },
                    new Equipment
                    {
                        Id = 3,
                        Description = "Whiteboard damage",
                        Name = "Standard Whiteboard",
                        OrderId = 1,
                    },
                    new Equipment
                    {
                        Id = 4,
                        Description = "Laptop issue",
                        Name = "Dell XPS 15",
                        OrderId = 1,
                    },
                    new Equipment
                    {
                        Id = 5,
                        Description = "Microphone not working",
                        Name = "Shure SM58",
                        OrderId = 1,
                    }


               );
        }
    }
}
