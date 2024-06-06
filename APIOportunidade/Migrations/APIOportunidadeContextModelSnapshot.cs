﻿// <auto-generated />
using System;
using APIOportunidade.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIOportunidade.Migrations
{
    [DbContext(typeof(APIOportunidadeContext))]
    partial class APIOportunidadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Oportunidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<long>("aprendizadoNvl")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("dataEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("horasDeSono")
                        .HasColumnType("smallint");

                    b.Property<int>("horasFolga")
                        .HasColumnType("int");

                    b.Property<string>("nvlSurto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("qtdErros")
                        .HasColumnType("bigint");

                    b.Property<int>("qtdHoras")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Oportunidade");
                });
#pragma warning restore 612, 618
        }
    }
}
