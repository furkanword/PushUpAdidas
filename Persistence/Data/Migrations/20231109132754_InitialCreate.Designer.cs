﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20231109132754_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Entities.DetailTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TransaccionId")
                        .HasColumnType("int");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionId");

                    b.ToTable("DetailTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Rol")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description_Rol")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("descRol");

                    b.Property<string>("Name_Rol")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("NameRol");

                    b.HasKey("Id");

                    b.ToTable("Rol", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description_Rol = "Rol de administrador",
                            Name_Rol = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Description_Rol = "Gestor de administracion",
                            Name_Rol = "Gerente"
                        },
                        new
                        {
                            Id = 3,
                            Description_Rol = "Asalariado de la empresa",
                            Name_Rol = "Empleado"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserIdFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_User")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("Email");

                    b.Property<int>("IdCustomerFk")
                        .HasColumnType("int");

                    b.Property<string>("Name_User")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("NameUser");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "angel@gmail.com",
                            IdCustomerFk = 0,
                            Name_User = "Angel",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sofia@gmail.com",
                            IdCustomerFk = 0,
                            Name_User = "sofia",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 3,
                            Email = "lucia@gmail.com",
                            IdCustomerFk = 0,
                            Name_User = "lucia",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("UsersRols");
                });

            modelBuilder.Entity("Domain.Entities.DetailTransaction", b =>
                {
                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany("DetailTransactions")
                        .HasForeignKey("ProductId");

                    b.HasOne("Domain.Entities.Transaction", "Transaction")
                        .WithMany("DetailTransactions")
                        .HasForeignKey("TransactionId");

                    b.Navigation("Product");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Domain.Entities.Transaction", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Users")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("UserRols")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserRols")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Navigation("DetailTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UserRols");
                });

            modelBuilder.Entity("Domain.Entities.Transaction", b =>
                {
                    b.Navigation("DetailTransactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("UserRols");
                });
#pragma warning restore 612, 618
        }
    }
}
