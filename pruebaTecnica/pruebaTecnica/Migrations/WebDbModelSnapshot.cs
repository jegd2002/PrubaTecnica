﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pruebaTecnica.Data;

#nullable disable

namespace pruebaTecnica.Migrations
{
    [DbContext(typeof(WebDb))]
    partial class WebDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pruebaTecnica.Models.productos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("imagen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("listaDePrecios")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("porcentajeIva")
                        .HasColumnType("integer");

                    b.Property<bool>("productoParaLaVenta")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("productos");
                });
#pragma warning restore 612, 618
        }
    }
}
