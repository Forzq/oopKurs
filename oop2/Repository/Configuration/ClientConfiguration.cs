using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using oop2.Models;

namespace oop2.Repository.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder <Client> builder)
        {
            builder.HasData
                (
                    new Client
                    {
                        Id = 1,
                        Name = "Jesus228",
                        PhoneNumber = "+375445566333"
                    },
                    new Client
                    {
                        Id =2,
                        Name = "Mr.P",
                        PhoneNumber = "+375447300486"
                    },
                    new Client
                    {
                        Id = 3,
                        Name = "Ms. A",
                        PhoneNumber = "+375447300487"
                    },
                    new Client
                    {
                        Id = 4,
                        Name = "Mr. B",
                        PhoneNumber = "+375447300488"
                    },
                    new Client
                    {
                        Id = 5,
                        Name = "Mrs. C",
                        PhoneNumber = "+375447300489"
                    }

                );
            
        }
    }
}
