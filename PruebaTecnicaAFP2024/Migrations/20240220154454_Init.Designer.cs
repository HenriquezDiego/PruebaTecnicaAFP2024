﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaTecnicaAFP2024.DataAccess;

#nullable disable

namespace PruebaTecnicaAFP2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240220154454_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaTecnicaAFP2024.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Rojo"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Azul"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Blanco"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Negro"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Gris"
                        });
                });

            modelBuilder.Entity("PruebaTecnicaAFP2024.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Toyota"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Honda"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Ford"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Chevrolet"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Nissan"
                        },
                        new
                        {
                            Id = 7,
                            Nombre = "BMW"
                        },
                        new
                        {
                            Id = 8,
                            Nombre = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 9,
                            Nombre = "Audi"
                        },
                        new
                        {
                            Id = 10,
                            Nombre = "Hyundai"
                        });
                });

            modelBuilder.Entity("PruebaTecnicaAFP2024.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPuertas")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroPlaca")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("PruebaTecnicaAFP2024.Models.Vehiculo", b =>
                {
                    b.HasOne("PruebaTecnicaAFP2024.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaTecnicaAFP2024.Models.Marca", "Marca")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("PruebaTecnicaAFP2024.Models.Marca", b =>
                {
                    b.Navigation("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
