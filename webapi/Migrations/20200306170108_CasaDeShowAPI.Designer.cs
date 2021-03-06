﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Data;

namespace webapi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200306170108_CasaDeShowAPI")]
    partial class CasaDeShowAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("webapi.Models.CasaDeShow", b =>
                {
                    b.Property<int>("CasaDeShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeDaCasa")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CasaDeShowId");

                    b.ToTable("CasasDeShow");
                });

            modelBuilder.Entity("webapi.Models.Eventos", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeDoEvento")
                        .HasColumnType("int");

                    b.Property<int>("CasaDeShowId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDoEvento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GeneroDoEvento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeDoEvento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QuantidadeDeIngressos")
                        .HasColumnType("int");

                    b.Property<double>("ValorDoIngresso")
                        .HasColumnType("double");

                    b.HasKey("EventoId");

                    b.HasIndex("CasaDeShowId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("webapi.Models.Ingresso", b =>
                {
                    b.Property<int>("IngressoKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EventosId")
                        .HasColumnType("int");

                    b.HasKey("IngressoKey");

                    b.HasIndex("EventosId");

                    b.ToTable("Ingressos");
                });

            modelBuilder.Entity("webapi.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("webapi.Models.Eventos", b =>
                {
                    b.HasOne("webapi.Models.CasaDeShow", "CasasDeShow")
                        .WithMany()
                        .HasForeignKey("CasaDeShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Models.Ingresso", b =>
                {
                    b.HasOne("webapi.Models.Eventos", "Eventos")
                        .WithMany()
                        .HasForeignKey("EventosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
