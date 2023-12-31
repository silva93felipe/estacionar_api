﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using estacionamento.context;

#nullable disable

namespace estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoContext))]
    [Migration("20230620015212_IncluirVeiculos")]
    partial class IncluirVeiculos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("estacionamento.Models.Estacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<int>("Capacidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7787));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("TempoPadrao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TempoTolerancia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7628));

                    b.Property<double>("ValorHora")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorTaxaInicial")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Estacionamento");
                });

            modelBuilder.Entity("estacionamento.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreatAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7234));

                    b.Property<string>("DocumentoProprietario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NomeProprietario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("Tipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 6, 20, 1, 52, 12, 582, DateTimeKind.Utc).AddTicks(7096));

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
