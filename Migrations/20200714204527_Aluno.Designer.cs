﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteApi.Data.DataContext;

namespace TesteApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200714204527_Aluno")]
    partial class Aluno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteApi.AlunoModel.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int")
                        .HasMaxLength(5);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
