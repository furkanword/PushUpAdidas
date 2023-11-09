using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customer");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("Id_Customer")
        .HasColumnType("int")
        .IsRequired();


        builder.Property(p => p.Name)
        .HasColumnName("Name")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();


        builder.Property(p => p.LastName)
       .HasColumnName("LastName")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.Address)
       .HasColumnName("Address")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.City)
        .HasColumnName("City")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.PostalCode)
        .HasColumnName("PostalCode")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Country)
        .HasColumnName("Country")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Email)
        .HasColumnName("Email")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.Phone)
        .HasColumnName("Phone")
        .HasColumnType("Int")
        .IsRequired();

        builder.HasMany( p=> p.Users)
        .WithOne(p=> p.Customer)
        .HasForeignKey(p=> p.IdCustomerFk);
    
       
        builder.HasData(
            new Customer
            {
                Id = 1,
                Name = "Angel",
                LastName = "stiwar",
                Address = "Calle-31",
                City = "Ciudad De Mexico",
                PostalCode = "123412",
                Country = "Mexico",
                Email = "angel@gmail.com",
                Phone = 123456789
            },
            new Customer
            {
                Id = 2,
                Name = "Kevin",
                LastName = "Arce",
                Address = "Calle-33",
                City = "Medellin",
                PostalCode = "12334",
                Country = "Colombia",
                Email = "kevin@gmail.com",
                Phone = 123412321
            },
                new Customer
            {
                Id = 3,
                Name = "Gabriel",
                LastName = "aertre",
                Address = "Calle-35",
                City = "Medellin",
                PostalCode = "16555",
                Country = "Colombia",
                Email = "gabriel@gmail.com",
                Phone = 123456789
            }

        );



    }
}