using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module_4.HW_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4.HW_5.DBConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.ClientId);
            builder.Property(c => c.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Age).IsRequired();

            builder.HasData(
                new Client { ClientId = 1, FirstName = "Olha", LastName = "Pivniuk", Age = 45, Email = "o.pivniuk@gmail.com" },
                new Client { ClientId = 2, FirstName = "Ivan", LastName = "Kovalenko", Age = 24, Email = "ivan24@gmail.com" },
                new Client { ClientId = 3, FirstName = "Stepan", LastName = "Vashenko", Age = 65, Email = "vashenko65@gmail.com" },
                new Client { ClientId = 4, FirstName = "Tetiana", LastName = "Noveniuk", Age = 23, Email = "tetianka45@ukr.net" },
                new Client { ClientId = 5, FirstName = "Timofiy", LastName = "Kurchenko", Age = 42, Email = "timofiy.kurchenko@outlook.com" });
        }
    }
}
