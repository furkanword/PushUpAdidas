using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transaction");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("Id_Transaction")
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.Date)
       .HasColumnName("Date")
       .HasColumnType("DateTime")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.Total)
       .HasColumnName("Total")
       .HasColumnType("decimal")
       .IsRequired();

        builder.Property(p => p.State)
        .HasColumnName("State")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.UserIdFk)
        .HasColumnName("UserIdFk")
        .HasColumnType("int")
        .IsRequired();

        builder.HasMany( p=> p.DetailTransactions)
        .WithOne(p=> p.Transaction)
        .HasForeignKey(p=> p.TransaccionId);

       
        builder.HasData(
            new Transaction
            {
                Id = 1,
                Date = new DateTime(2023, 11, 9),
                Total = 130
            },
            new Transaction
            {
                Id = 2,
                Date = new DateTime(2023, 31, 12),
                Total = 300
            },
            new Transaction
            {
                Id = 3,
                Date = new DateTime(2023, 21, 06),
                Total = 40
            }

        );



    }
}