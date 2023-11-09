using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("Id_Product")
        .HasColumnType("int")
        .IsRequired();


        builder.Property(p => p.Name)
        .HasColumnName("Name")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();


        builder.Property(p => p.Description)
       .HasColumnName("Description")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.Price)
       .HasColumnName("Price")
       .HasColumnType("decimal")
       .IsRequired();

        builder.Property(p => p.Stock)
        .HasColumnName("Stock")
        .HasColumnType("int")
        .IsRequired();

        builder.HasMany( p=> p.DetailTransactions)
        .WithOne(p=> p.Product)
        .HasForeignKey(p=> p.ProductoIdFk);

       
        builder.HasData(
            new Product
            {
                Id = 1,
                Name = "Camisa",
                Description = "Algodon",
                Stock = 120,
                Price = 16
            },
            new Product
            {
                Id = 2,
                Name = "Tenis",
                Description = "Deportivo",
                Stock = 239,
                Price = 230
            },
                new Product
            {
                Id = 3,
                Name = "bolso",
                Description = "Alpinismo",
                Stock = 200,
                Price = 400
            }

        );



    }
}