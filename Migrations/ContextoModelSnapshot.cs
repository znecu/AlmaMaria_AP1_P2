﻿// <auto-generated />
using System;
using AlmaMaria_AP1_P2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlmaMaria_AP1_P2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlmaMaria_AP1_P2.Models.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Descripcion = "Procesador",
                            Monto = 15000.0
                        },
                        new
                        {
                            ArticuloId = 2,
                            Descripcion = "Tarjeta Gráfica",
                            Monto = 24000.0
                        },
                        new
                        {
                            ArticuloId = 3,
                            Descripcion = "Ram",
                            Monto = 7000.0
                        },
                        new
                        {
                            ArticuloId = 4,
                            Descripcion = "SSD",
                            Monto = 8000.0
                        },
                        new
                        {
                            ArticuloId = 5,
                            Descripcion = "Refrigeración",
                            Monto = 12000.0
                        },
                        new
                        {
                            ArticuloId = 6,
                            Descripcion = "Placa Madre",
                            Monto = 13000.0
                        });
                });

            modelBuilder.Entity("AlmaMaria_AP1_P2.Models.Combos", b =>
                {
                    b.Property<int>("CombosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CombosId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.HasKey("CombosId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("AlmaMaria_AP1_P2.Models.CombosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CombosId")
                        .HasColumnType("int");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.HasKey("DetalleId");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("CombosId");

                    b.ToTable("CombosDetalles");
                });

            modelBuilder.Entity("AlmaMaria_AP1_P2.Models.CombosDetalle", b =>
                {
                    b.HasOne("AlmaMaria_AP1_P2.Models.Articulos", "Articulos")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlmaMaria_AP1_P2.Models.Combos", "Combos")
                        .WithMany()
                        .HasForeignKey("CombosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulos");

                    b.Navigation("Combos");
                });
#pragma warning restore 612, 618
        }
    }
}
