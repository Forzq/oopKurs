using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class MasterConfiguration : IEntityTypeConfiguration<Master>
    {
        public void Configure(EntityTypeBuilder<Master> builder)
        {
            builder.HasData
               (
                   new Master
                   {
                       Id = 1,
                       Name = "Dyadya",
                       contactInfo = "dyadya@gmail.com",
                       specialization = "screen fixer"
                   },
                   new Master
                   {
                       Id = 2,
                       Name = "Vanya",
                       contactInfo = "vanya@gmail.com",
                       specialization = "laptop repair"
                   },
                    new Master
                    {
                        Id = 3,
                        Name = "Sasha",
                        contactInfo = "sasha@gmail.com",
                        specialization = "printer technician"
                    },
                    new Master
                    {
                        Id = 4,
                        Name = "Misha",
                        contactInfo = "misha@gmail.com",
                        specialization = "network specialist"
                    },
                    new Master
                    {
                        Id = 5,
                        Name = "Katya",
                        contactInfo = "katya@gmail.com",
                        specialization = "mobile device repair"
                    }


               );
        }
    }
}
