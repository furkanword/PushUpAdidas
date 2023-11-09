using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Rol")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Name_Rol)
            .HasColumnName("NameRol")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


            builder.Property(p => p.Description_Rol)
            .HasColumnName("descRol")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();




             builder.HasData(
                new Rol
                {
                    Id = 1,
                    Name_Rol = "Admin",
                    Description_Rol = "Rol de administrador"
                },
                new Rol
                {
                    Id = 2,
                    Name_Rol = "Gerente",
                    Description_Rol = "Gestor de administracion"
                },
                new Rol
                {
                    Id = 3,
                    Name_Rol = "Empleado",
                    Description_Rol = "Asalariado de la empresa"
                }
            );

    }
}