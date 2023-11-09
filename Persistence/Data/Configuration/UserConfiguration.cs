using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("Id_User")
        .HasColumnType("int")
        .IsRequired();


        builder.Property(p => p.Name_User)
        .HasColumnName("NameUser")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();


        builder.Property(p => p.Password)
       .HasColumnName("Password")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();

        builder.Property(p => p.Email)
        .HasColumnName("Email")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder
       .HasMany(p => p.Rols)
       .WithMany(r => r.Users)
       .UsingEntity<UserRol>(

           j => j
           .HasOne(pt => pt.Rol)
           .WithMany(t => t.UserRols)
           .HasForeignKey(ut => ut.RolId),


           j => j
           .HasOne(et => et.User)
           .WithMany(et => et.UserRols)
           .HasForeignKey(el => el.UserId),

           j =>
           {
               j.HasKey(t => new { t.UserId, t.RolId });

           });

            builder.HasData(
                new User
                {
                    Id = 1,
                    Name_User = "Angel",
                    Password = "1234",
                    Email = "angel@gmail.com"
                },
                new User
                {
                    Id = 2,
                    Name_User = "sofia",
                    Password = "1234",
                    Email = "sofia@gmail.com"
                },
                 new User
                {
                    Id = 3,
                    Name_User = "lucia",
                    Password = "1234",
                    Email = "lucia@gmail.com"
                }

            );



    }
}